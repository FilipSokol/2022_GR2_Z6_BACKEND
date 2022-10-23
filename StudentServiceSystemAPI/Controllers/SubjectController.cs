using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [Route("api/subjects")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Subject>> GetById([FromRoute] int id)
        {
            var subject = await this.subjectRepository.GetById(id);
            return Ok(subject);
        }
        [HttpGet]
        public async Task<ActionResult<List<Subject>>> GetAll()
        {
            var subjects = await this.subjectRepository.GetAll();
            return Ok(subjects);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody]Student student)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody]Student student)
        {
            throw new NotImplementedException();
        }
    }
}
