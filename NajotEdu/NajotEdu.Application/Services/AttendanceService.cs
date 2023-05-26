using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models.Attendence;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        public AttendanceService(IApplicationDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }
        public async Task<IEnumerable<Attendance>> CheckAsync(DoAttendenceCheckModel model)
        {
            var lesson = await _context.Lessons.Include(a => a.Group).FirstOrDefaultAsync(a => a.Id == model.LessonId);
            if (lesson == null || _currentUserService.UserId != lesson.Group.TeacherId)
            {
                throw new Exception("You don't have that group");
            }



            var groupStudentIds = await _context.Lessons    // lessons ichida group bor edi
                .Where(a => a.Id == model.LessonId)         // bu yerda qaysi darsligini belgilab oldik
                .Include(a => a.Group)                      // groupni ichida groupStudents bor
                .ThenInclude(a => a.GroupStudents)          // bu yerda tablitsalarni join qilib olindi
                .SelectMany(a => a.Group.GroupStudents)     // a bu yerda Lesson dan  undan kegin ICollection<StudentGroup> GroupStudents collectionni olyapmiz
                .Select(a => a.StudentId)                   // va bu collectionning har bitta classning studentId larini 
                .ToListAsync();                             // listga yigib oldim bu adilar ruyhatiga aylandi

            var attendenceList = new List<Attendance>();
            var attendanceTrue = new List<Attendance>();
            foreach (var studentId in groupStudentIds)
            {
                var check = model.Checks.FirstOrDefault(model => model.StudentId == studentId);

                var attendance = new Attendance()
                {
                    StudentId = studentId,
                    LessonId = model.LessonId,
                    HasParticipated = false
                };

                if (check != null)
                {
                    attendance.HasParticipated = check.HasParticipated;
                }

                attendenceList.Add(attendance);
                if (attendance.HasParticipated == true)
                {
                    attendanceTrue.Add(attendance);
                }
            }

            _context.Attendances.AddRangeAsync(attendenceList);

            await _context.SaveChangesAsync();

            return attendanceTrue;
        }
    }
}
