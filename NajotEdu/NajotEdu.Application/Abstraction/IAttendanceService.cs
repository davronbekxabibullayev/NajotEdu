using NajotEdu.Application.Models.Attendence;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Abstraction
{
    public interface IAttendanceService
    {
        Task<IEnumerable<Attendance>> CheckAsync(DoAttendenceCheckModel model);
    }
}
