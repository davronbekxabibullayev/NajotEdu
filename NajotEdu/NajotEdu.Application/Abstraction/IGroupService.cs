using NajotEdu.Application.Models;
using NajotEdu.Application.Models.Group;
using NajotEdu.Application.Models.Lesson;

namespace NajotEdu.Application.Abstraction
{
    public interface IGroupService : ICRUDService<int, GroupViewModel, CreateGroupModel, UpdateGroupViewModel>
    {
        Task AddStudentAsync(AddStudentGroupModel model, int groupId);
        Task RemoveStudentGroupAsync(int studentId, int groupId);
        Task<List<LessonModel>> GetLessons(int groupId);


    }
}
