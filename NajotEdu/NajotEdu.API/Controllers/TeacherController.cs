using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;

namespace NajotEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //    [Authorize(Policy = "Admin")] bu yerda tursa bu quyidagi barcha controllerlarga tasir qiladi 
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]

        public async Task<IActionResult> CreateTeacher(CreateTeacherModel createTeacherModel)
        {
            var result = await _teacherService.Create(createTeacherModel);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher(UpdateTeacherModel updateTeacherModel)
        {
            var result = await _teacherService.Update(updateTeacherModel);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteTeacher(int Id)
        {
            var result = await _teacherService.Delete(Id);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var teacher = await _teacherService.GetById(Id);

            return Ok(teacher);
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            var result = await _teacherService.GetAll();
            return Ok(result);
        }
    }
}
