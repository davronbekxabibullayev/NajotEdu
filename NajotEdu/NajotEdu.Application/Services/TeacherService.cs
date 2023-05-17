using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IHashProvider _hashProvider;

        public TeacherService(IApplicationDbContext applicationDbContext, IHashProvider hashProvider)
        {
            _applicationDbContext = applicationDbContext;
            _hashProvider = hashProvider;
        }

        public async Task<string> Create(CreateTeacherModel createTeacherModel)
        {
            var teacher = await _applicationDbContext.Users.FirstOrDefaultAsync(a => a.UserName == createTeacherModel.UserName);

            if (teacher != null)
            {
                throw new Exception("This user is already exist!");
            }

            var newTeacher = new User()
            {
                UserName = createTeacherModel.UserName,
                FullName = createTeacherModel.FullName,
                PasswordHash = _hashProvider.GetHash(createTeacherModel.Password),
                Role = Domain.Enum.UserRole.Teacher
            };

            _applicationDbContext.Users.Add(newTeacher);
            await _applicationDbContext.SaveChangesAsync();

            return newTeacher.UserName;
        }

        public async Task<int> Delete(int id)
        {
            var teacher = await _applicationDbContext.Users.FirstOrDefaultAsync(a => a.Id == id);

            if (teacher == null)
            {
                throw new Exception("This id is not found");
            }

            _applicationDbContext.Users.Remove(teacher);
            await _applicationDbContext.SaveChangesAsync();

            return teacher.Id;
        }

        public async Task<IEnumerable<TeacherViewModel>> GetAll()
        {
            return await _applicationDbContext.Users.Where(a => a.Role == Domain.Enum.UserRole.Teacher)
                .Select(a => new TeacherViewModel
                {
                    UserName = a.UserName,
                    FullName = a.FullName,
                }).ToListAsync();
        }

        public async Task<TeacherViewModel> GetById(int id)
        {

            var teacher = await _applicationDbContext.Users.FirstOrDefaultAsync(a => a.Id == id);

            if (teacher == null)
            {
                throw new Exception("This Id is not found");
            }

            var teacherModel = new TeacherViewModel
            {
                FullName = teacher.FullName,
                UserName = teacher.UserName
            };

            return teacherModel;
        }

        public async Task<int> Update(UpdateTeacherModel updateTeacherModel)
        {
            var teacher = await _applicationDbContext.Users.FirstOrDefaultAsync(a => a.Id ==
            updateTeacherModel.Id && a.Role == Domain.Enum.UserRole.Teacher);

            if (teacher == null)
            {
                throw new Exception("This user is not found");
            }

            teacher.FullName = updateTeacherModel.FullName;
            teacher.UserName = updateTeacherModel.UserName;
            teacher.PasswordHash = _hashProvider.GetHash(updateTeacherModel.Password);

            _applicationDbContext.Users.Update(teacher);
            await _applicationDbContext.SaveChangesAsync();

            return teacher.Id;

        }
    }
}
