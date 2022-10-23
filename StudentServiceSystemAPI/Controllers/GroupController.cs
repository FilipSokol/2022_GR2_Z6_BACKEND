using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

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
        public async Task<ActionResult<Group>> GetById([FromRoute]int departmentId, [FromRoute] int groupId)
        {
            var group = await this.groupRepository.GetById(departmentId, groupId);
            return Ok(group);
        }

        [HttpGet]
        public async Task<ActionResult<List<Group>>> GetAll([FromRoute] int departmentId)
        {
            var groups = await this.groupRepository.GetAll(departmentId);
            return Ok(groups);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromRoute] int departmentId, [FromBody] Group group)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveAll([FromRoute] int departmentId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{groupId}")]
        public async Task<ActionResult> Remove([FromRoute] int departmentId, [FromRoute] int groupId)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromRoute] int departmentId, [FromRoute] int groupId, [FromBody] Group group)
        {
            throw new NotImplementedException();
        }
    }
}
