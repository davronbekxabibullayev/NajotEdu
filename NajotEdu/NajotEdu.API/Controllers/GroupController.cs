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

        [HttpPost]
        [Authorize(Policy = "Admin")]

        public async Task<IActionResult> CreateStudent(CreateGroupModel createGroupModel)
        {
            var result = await _groupService.Create(createGroupModel);

            return Ok(result);
        }

        [HttpPost("{groupId}/student")]
        [Authorize]
        public async Task<IActionResult> AddStudent(AddStudentGroupModel model, [FromRoute] int groupId)
        {
            await _groupService.AddStudentAsync(model, groupId);

            return Ok();
        }

        [HttpPut]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdateGroup([FromForm] UpdateGroupViewModel updateGroupModel)
        {
            var result = await _groupService.Update(updateGroupModel);
            return Ok(result);
        }


        [HttpGet("{Id}")]
        [Authorize]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var result = await _groupService.GetById(Id);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        [Authorize]

        public async Task<IActionResult> GetAll()
        {
            var result = await _groupService.GetAll();
            return Ok(result);
        }

        [HttpGet("{groupId}/lessons")]
        [Authorize]
        public async Task<IActionResult> GetLessons(int groupId)
        {
            var lessons = await _groupService.GetLessons(groupId);

            return Ok(lessons);
        }


        [HttpDelete("{groupId}/student")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> RemoveStudentGroup([FromForm] int studentId, [FromRoute] int groupId)
        {
            await _groupService.RemoveStudentGroupAsync(studentId, groupId);

            return Ok();
        }

        [HttpDelete("{Id}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteGroup([FromForm] int Id)
        {
            var result = await _groupService.Delete(Id);
            return Ok(result);
        }

    }
}
