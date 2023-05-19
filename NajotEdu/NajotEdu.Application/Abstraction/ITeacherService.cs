using NajotEdu.Application.Models;

namespace NajotEdu.Application.Abstraction
{
    public interface ITeacherService
    {
        Task<TeacherViewModel> GetById(int id);
        Task<IEnumerable<TeacherViewModel>> GetAll();
        Task<string> Create(CreateTeacherModel createTeacherModel);
        Task<int> Update(UpdateTeacherModel updateTeacherModel);
        Task<int> Delete(int id);
    }
}
