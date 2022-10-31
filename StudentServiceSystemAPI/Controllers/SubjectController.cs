using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using System.Text.RegularExpressions;

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
        public async Task<ActionResult<int>> Create([FromBody]CreateSubjectDto dto)
        {
            var id = await this.subjectRepository.Create(dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            await this.subjectRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody]SubjectDto dto)
        {
            await this.subjectRepository.Update(id, dto);
            return Ok();
        }
    }
}
