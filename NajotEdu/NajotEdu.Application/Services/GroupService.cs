using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;
using NajotEdu.Application.Models.Group;
using NajotEdu.Application.Models.Lesson;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IApplicationDbContext _dbContext;
        public GroupService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> Delete(int Id)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == Id);

            if (group != null)
            {
                throw new Exception("not found");
            }

            _dbContext.Groups.Remove(group);
            await _dbContext.SaveChangesAsync();

            return Id;
        }

        public async Task<IEnumerable<GroupViewModel>> GetAll()
        {
            var groups = await _dbContext.Groups.Select(a => new GroupViewModel()
            {
                EndDate = a.EndDate,
                StartDate = a.StartDate,
                TeacherFullName = a.Teacher.FullName,
                Name = a.Name
            }).ToListAsync();

            if (groups.Count == 0)
            {
                throw new Exception("Sorry, There isn't any groups.");
            }

            return groups;
        }

        public async Task<GroupViewModel> GetById(int Id)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == Id);

            if (group == null)
            {
                throw new Exception("not found");
            }

            var model = new GroupViewModel()
            {
                EndDate = group.EndDate,
                StartDate = group.StartDate,
                TeacherFullName = "group.Teacher.FullName",
                Name = group.Name
            };

            return model;
        }
        public async Task<string> Create(CreateGroupModel createModel)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Name == createModel.Name
            && a.StartDate == createModel.StartDate
            && a.EndDate == createModel.EndDate
            && a.TeacherId == createModel.TeacherId);



            if (group != null)
            {
                throw new Exception("This group is already exist!");
            }

            var newGroup = new Group()
            {
                Name = createModel.Name,
                StartDate = createModel.StartDate,
                EndDate = createModel.EndDate,
                TeacherId = createModel.TeacherId
            };

            await _dbContext.Groups.AddAsync(newGroup);

            var lessons = new List<Lesson>();

            var totalLessonsFromStartToEnd = (newGroup.EndDate - newGroup.StartDate).Days;
            var currentDate = newGroup.StartDate;

            for (int a = 0; a <= totalLessonsFromStartToEnd; a++)
            {
                if (currentDate.DayOfWeek != DayOfWeek.Sunday && currentDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    var lesson = new Lesson()
                    {
                        Group = newGroup,
                        StartDateTime = currentDate.Date + createModel.LessonStartTime,
                        EndDateTime = currentDate.Date + createModel.LessonEndTime,
                    };

                    lessons.Add(lesson);
                }

                currentDate = currentDate.AddDays(1);
            }


            _dbContext.Lessons.AddRange(lessons);
            await _dbContext.SaveChangesAsync();

            return "New group is saved";
        }
        public async Task<int> Update(UpdateGroupViewModel updateModel)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == updateModel.Id);

            if (group != null)
            {
                throw new Exception("Not found");
            }

            group.StartDate = updateModel.StartDate ?? group.StartDate; // bu degani update qilganida agar
            group.EndDate = updateModel.EndDate ?? group.EndDate;       // ushbu fieldni yangi qiymatini 
            group.Name = updateModel.Name ?? group.Name;                // bersa uzgaradi bulmasa eskisi qoldi degani
            group.TeacherId = updateModel.TeacherId ?? group.TeacherId; // bu uchun updategroupviewmodelda ushbu field 
                                                                        // nullable bulishi kerak buladi

            if (updateModel.StartDate.HasValue)
            {
                var today = DateTime.UtcNow;

            }

            _dbContext.Groups.Update(group);
            await _dbContext.SaveChangesAsync();
            return group.Id;
        }

        public async Task AddStudentAsync(AddStudentGroupModel model, int groupId)
        {
            var student = await _dbContext.Students.FirstAsync(a => a.Id == model.StudentId); ;

            if (student == null)
            {
                throw new Exception("student is not found");
            }

            if (!await _dbContext.Groups.AnyAsync(a => a.Id == groupId))
            {
                throw new Exception("group is not found");
            }


            var studentGroup = new StudentGroup()
            {
                JoinedDate = model.JoinedDate,
                StudentId = model.StudentId,
                GroupId = groupId,
                IsPayed = model.IsPayed,
            };

            _dbContext.StudentGroups.Add(studentGroup);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveStudentGroupAsync(int studentId, int groupId)
        {
            var studentGroup = _dbContext.StudentGroups.FirstOrDefault(a => a.StudentId == studentId && a.GroupId == groupId);

            if (studentGroup == null)
            {
                throw new Exception("not found");
            }

            _dbContext.StudentGroups.Remove(studentGroup);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<LessonModel>> GetLessons(int groupId)
        {
            var lessons = await _dbContext.Lessons.Where(a => a.GroupId == groupId).Select(a => new LessonModel()
            {
                Id = a.Id,
                GroupId = a.GroupId,
                EndDateTime = a.EndDateTime,
                StartDateTime = a.StartDateTime,
            }).ToListAsync();

            return lessons;
        }
    }
}
