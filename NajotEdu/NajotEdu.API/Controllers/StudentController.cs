using Microsoft.AspNetCore.Authorization;
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
            var result = await _studentService.Create(createStudentModel);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentModel updateStudentModel)
        {
            var result = await _studentService.Update(updateStudentModel);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStudent(int Id)
        {
            var result = await _studentService.Delete(Id);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var result = await _studentService.GetById(Id);
            return Ok(result);
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            var result = await _studentService.GetAll();
            return Ok(result);
        }
    }
}
