using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IHashProvider _hashProvider;

        public StudentService(IApplicationDbContext applicationDbContext, IHashProvider hashProvider)
        {
            _applicationDbContext = applicationDbContext;
            _hashProvider = hashProvider;
        }

        public async Task<int> Create(CreateStudentModel createStudentModel)
        {
            var student = await _applicationDbContext.Students.FirstOrDefaultAsync(a =>
            a.FullName == createStudentModel.FullName && a.Birthdate == createStudentModel.BirthDate);

            if (student != null)
            {
                throw new Exception("This student already exist!");
            }

            var newStudent = new Student()
            {
                FullName = createStudentModel.FullName,
                Birthdate = createStudentModel.BirthDate,
                PhoneNumber = createStudentModel.PhoneNumber,
                CreatedDate = DateTimeOffset.Now
            };

            await _applicationDbContext.Students.AddAsync(newStudent);
            await _applicationDbContext.SaveChangesAsync();

            return newStudent.Id;
        }

        public async Task<int> Delete(int id)
        {
            var student = await _applicationDbContext.Students.FirstOrDefaultAsync(a => a.Id == id);

            if (student == null)
            {
                throw new Exception("not found!");
            }

            _applicationDbContext.Students.Remove(student);
            await _applicationDbContext.SaveChangesAsync();

            return student.Id;

        }

        public async Task<IEnumerable<StudentViewModel>> GetAll()
        {
            return await _applicationDbContext.Students.Select(a => new StudentViewModel()
            {
                FullName = a.FullName,
                BirthDate = a.Birthdate,
                CreatedDate = a.CreatedDate,
                PhoneNumber = a.PhoneNumber
            }).ToListAsync();
        }

        public async Task<StudentViewModel> GetById(int id)
        {
            var student = await _applicationDbContext.Students.FirstOrDefaultAsync(a => a.Id == id);

            if (student == null)
            {
                throw new Exception("not found!");
            }
            var studentViewModel = new StudentViewModel()
            {
                BirthDate = student.Birthdate,
                CreatedDate = student.CreatedDate,
                PhoneNumber = student.PhoneNumber,
                FullName = student.FullName
            };

            return studentViewModel;
        }

        public async Task<int> Update(UpdateStudentModel updateStudentModel)
        {
            var student = await _applicationDbContext.Students.FirstOrDefaultAsync(a => a.Id == updateStudentModel.Id);

            if (student == null)
            {
                throw new Exception("not found!");
            }

            student.Birthdate = updateStudentModel.BirthDate;
            student.PhoneNumber = updateStudentModel.PhoneNumber;
            student.FullName = updateStudentModel.FullName;

            _applicationDbContext.Students.Update(student);
            await _applicationDbContext.SaveChangesAsync();

            return student.Id;

        }
    }
}
