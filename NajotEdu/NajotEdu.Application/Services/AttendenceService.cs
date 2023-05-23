
using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models.Attendence;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class AttendenceService : IAttendenceService
    {
        private readonly IApplicationDbContext _context;
        public async Task<string> Create(Models.Attendence.CreatAttendenceModel createModel)
        {
            var attendence1 = await _context.Attendences.FirstOrDefaultAsync(a => a.JoinedDate == createModel.JoinedDate
            && a.StudentId == createModel.StudentId && a.LessonId == createModel.LessonId);

            if (attendence1 != null)
            {
                throw new Exception("This attendence is already exist!");
            }

            var attendence = new Attendence()
            {
                StudentId = createModel.StudentId,
                LessonId = createModel.LessonId,
                JoinedDate = createModel.JoinedDate
            };

            _context.Attendences.Add(attendence);
            await _context.SaveChangesAsync();

            return "New attendence is created";
        }

        public async Task<int> Delete(int id)
        {
            var attendence = await _context.Attendences.FirstOrDefaultAsync(a => a.Id == id);

            if (attendence != null)
            {
                throw new Exception("not found");
            }

            _context.Attendences.Remove(attendence);
            await _context.SaveChangesAsync();
            return attendence.Id;
        }

        public async Task<IEnumerable<Models.Attendence.AttendenceViewModel>> GetAll()
        {
            return await _context.Attendences.Select(a => new Models.Attendence.AttendenceViewModel()
            {
                JoinedDate = a.JoinedDate,
            }).ToListAsync();
        }

        public async Task<Models.Attendence.AttendenceViewModel> GetById(int Id)
        {
            var attendence = await _context.Attendences.FirstOrDefaultAsync(a => a.Id == Id);

            if (attendence != null)
            {
                throw new Exception("not found");
            }

            var newattendence = new Models.Attendence.AttendenceViewModel()
            {
                JoinedDate = attendence.JoinedDate
            };

            return newattendence;
        }

        public async Task<int> Update(UpdateAttendenceModel updateModel)
        {
            var attendence = await _context.Attendences.FirstOrDefaultAsync(a => a.Id == updateModel.Id);

            if (attendence != null)
            {
                throw new Exception("not found");
            }

            var updateAttendence = new Attendence()
            {
                JoinedDate = updateModel.JoinedDate,
                LessonId = updateModel.LessonId,
                StudentId = updateModel.StudentId
            };

            _context.Attendences.Update(updateAttendence);
            await _context.SaveChangesAsync();

            return updateModel.Id;
        }
    }
}
