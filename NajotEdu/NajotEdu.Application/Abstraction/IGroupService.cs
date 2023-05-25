using NajotEdu.Application.Models;
using NajotEdu.Application.Models.Group;

namespace NajotEdu.Application.Abstraction
{
    public interface IGroupService : ICRUDService<int, GroupViewModel, CreateGroupModel, UpdateGroupViewModel>
    {
        Task AddStudentAsync(AddStudentGroupModel model, int groupId);
        Task RemoveStudentGroupAsync(int studentId, int groupId);

    }
}
