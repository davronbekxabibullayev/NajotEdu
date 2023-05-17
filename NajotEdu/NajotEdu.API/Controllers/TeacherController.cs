using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;

namespace NajotEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            await _teacherService.Create(createTeacherModel);
            
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher(UpdateTeacherModel updateTeacherModel)
        {
            await _teacherService.Update(updateTeacherModel);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteTeacher(int Id)
        {
            await _teacherService.Delete(Id);
            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            await _teacherService.GetById(Id);
            return Ok();
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            await _teacherService.GetAll();
            return Ok();
        }
    }
}
