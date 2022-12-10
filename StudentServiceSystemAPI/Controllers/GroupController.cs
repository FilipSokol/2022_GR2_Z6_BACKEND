using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/departments/{departmentId}/groups")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }


        [HttpGet("{groupId}")]
        [SwaggerOperation(Summary = "Get group by departmentId and groupId")]
        public async Task<ActionResult<Group>> GetById([FromRoute]int departmentId, [FromRoute] int groupId)
        {
            var group = await this.groupRepository.GetById(departmentId, groupId);
            return Ok(group);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all groups from department by departmentId")]
        public async Task<ActionResult<List<Group>>> GetAll([FromRoute] int departmentId)
        {
            var groups = await this.groupRepository.GetAll(departmentId);
            return Ok(groups);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create group")]
        public async Task<ActionResult<int>> Create([FromRoute] int departmentId, [FromBody] CreateGroupDto group)
        {
            var id = await this.groupRepository.Create(departmentId, group);
            return Created($"/api/department/{id}", null);
        }

        [HttpDelete]
        [SwaggerOperation(Summary = "Remove all groups from department")]
        public async Task<ActionResult> RemoveAll([FromRoute] int departmentId)
        {
            await this.groupRepository.RemoveAll(departmentId);
            return NoContent();
        }

        [HttpDelete("{groupId}")]
        [SwaggerOperation(Summary = "Remove group from department")]
        public async Task<ActionResult> Remove([FromRoute] int departmentId, [FromRoute] int groupId)
        {
            await this.groupRepository.Remove(departmentId, groupId);
            return NoContent();
        }

        [HttpPut("{groupId}")]
        [SwaggerOperation(Summary = "Update group")]
        public async Task<ActionResult> Update([FromRoute] int departmentId, [FromRoute] int groupId, [FromBody] UpdateGroupDto group)
        {
            await this.groupRepository.Update(departmentId, groupId, group);
            return Ok();
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all subjects with students with marks")]
        [Route("/api/groups/{groupId}/subjects")]
        public async Task<ActionResult<List<SubjectsWithStudentsDto>>> GetSubjectsWithStudentsWithMarks([FromRoute] int groupId)
        {
            var group = await this.groupRepository.GetSubjectsWithStudentsWithMarks(groupId);
            return Ok(group);
        }
    }
}
