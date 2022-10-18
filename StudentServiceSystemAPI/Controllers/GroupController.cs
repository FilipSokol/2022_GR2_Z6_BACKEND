using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/departments/{departmentId}/groups")]
    public class GroupController : ControllerBase
    {
        private IGroupRepository groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        [HttpGet("{groupId}")]
        public async Task<ActionResult<Group>> GetById(int departmentId, int groupId)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<List<Group>>> GetAll(int departmentId)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<int>> Create(int departmentId, Group group)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> RemoveAll(int departmentId)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Remove(int departmentId, int groupId)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Update(int departmentId, int groupId, Group group)
        {
            throw new NotImplementedException();
        }
    }
}
