using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using System.Text.RegularExpressions;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/students/{studentId}/marks")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkRepository markRepository;

        public MarkController(IMarkRepository markRepository)
        {
            this.markRepository = markRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mark>> GetById([FromRoute] int studentId, [FromRoute]int id)
        {
            var mark = await this.markRepository.GetById(studentId, id);
            return Ok(mark);
        }

        [HttpGet]
        public async Task<ActionResult<List<Mark>>> GetAll([FromRoute] int studentId)
        {
            var marks = await this.markRepository.GetAll(studentId);
            return Ok(marks);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromRoute] int studentId, [FromBody] CreateMarkDto dto)
        {
            var id = await this.markRepository.Create(studentId, dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await this.markRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] UpdateMarkDto mark)
        {
            await this.markRepository.Update(id, mark);
            return Ok();
        }

        [HttpPost("subject")]
        public async Task<ActionResult> GetBySubjectName([FromRoute] int studentId, [FromBody] string name)
        {
            var subjectName = await this.markRepository.GetBySubjectName(studentId, name);

            if (subjectName is null)
            {
                throw new NullReferenceException("There is no subject with such name");
            }

            return Ok(subjectName);
        }
    }
}
