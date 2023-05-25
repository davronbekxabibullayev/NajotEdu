using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;
using NajotEdu.Application.Models.Group;

namespace NajotEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //    [Authorize(Policy = "Admin")] bu yerda tursa bu quyidagi barcha controllerlarga tasir qiladi 
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]

        public async Task<IActionResult> CreateStudent(CreateGroupModel createGroupModel)
        {
            var result = await _groupService.Create(createGroupModel);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGroup([FromForm]UpdateGroupViewModel updateGroupModel)
        {
            var result = await _groupService.Update(updateGroupModel);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteGroup([FromForm]int Id)
        {
            var result = await _groupService.Delete(Id);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var result = await _groupService.GetById(Id);
            return Ok(result);
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            var result = await _groupService.GetAll();
            return Ok(result);
        }

        [HttpPost("{groupId}/student")]
        public async Task<IActionResult> AddStudent(AddStudentGroupModel model, [FromRoute] int groupId)
        {
            await _groupService.AddStudentAsync(model, groupId);
            
            return Ok();
        }

        [HttpDelete("{groupId}/student")]
        public async Task<IActionResult> RemoveStudentGroup([FromForm]int studentId, [FromRoute] int groupId)
        {
            await _groupService.RemoveStudentGroupAsync(studentId, groupId);
            
            return Ok();
        }
    }
}
