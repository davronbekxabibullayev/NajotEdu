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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        [Authorize(Policy = "Admin")]
        [HttpPost]

        public async Task<IActionResult> CreateStudent(CreateStudentModel createStudentModel)
        {
            await _studentService.Create(createStudentModel);
            
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentModel updateStudentModel)
        {
            await _studentService.Update(updateStudentModel);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStudent(int Id)
        {
            await _studentService.Delete(Id);
            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            await _studentService.GetById(Id);
            return Ok();
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            await _studentService.GetAll();
            return Ok();
        }
    }
}
