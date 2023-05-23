using NajotEdu.Application.Models.Attendence;


namespace NajotEdu.Application.Abstraction
{
    public interface IAttendenceService : ICRUDService<int, Models.Attendence.AttendenceViewModel, Models.Attendence.CreatAttendenceModel, UpdateAttendenceModel>
    {

    }
}
