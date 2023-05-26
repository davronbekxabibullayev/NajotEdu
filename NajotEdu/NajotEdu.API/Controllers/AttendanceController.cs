using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models.Attendence;

namespace NajotEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // bu luboy parol login bilan kirgan user foydalanishi ruhsat degani
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpPost("Check")]

        public async Task<IActionResult> AttendanceCheck(DoAttendenceCheckModel model)
        {
            var participated = await _attendanceService.CheckAsync(model);

            return Ok(participated);
        }


    }
}
