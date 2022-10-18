using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/departments/{departmentId}/groups/{groupId}/students/{studentId}/marks")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkRepository markRepository;

        public MarkController(IMarkRepository markRepository)
        {
            this.markRepository = markRepository;
        }

        public async Task<ActionResult<Mark>> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<List<Mark>>> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult<int>> Create(Mark mark)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Update(int id, Mark mark)
        {
            throw new NotImplementedException();
        }
    }
}
