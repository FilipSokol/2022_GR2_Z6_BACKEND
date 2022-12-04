using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using System.Text.RegularExpressions;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly IMarkRepository markRepository;

        public MarkController(IMarkRepository markRepository)
        {
            this.markRepository = markRepository;
        }

        [HttpGet]
        [Route("api/students/{studentId}/marks/{id}")]
        public async Task<ActionResult<Mark>> GetById([FromRoute] int studentId, [FromRoute]int id)
        {
            var mark = await this.markRepository.GetById(studentId, id);
            return Ok(mark);
        }

        [HttpGet]
        [Route("api/students/{studentId}/marks")]
        public async Task<ActionResult<List<Mark>>> GetAll([FromRoute] int studentId)
        {
            var marks = await this.markRepository.GetAll(studentId);
            return Ok(marks);
        }
        [HttpPost]
        [Route("api/students/{studentId}/marks")]
        public async Task<ActionResult<int>> Create([FromRoute] int studentId, [FromBody] CreateMarkDto dto)
        {
            var id = await this.markRepository.Create(studentId, dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete]
        [Route("api/students/{studentId}/marks/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await this.markRepository.Delete(id);
            return NoContent();
        }
        [HttpPut]
        [Route("api/students/{studentId}/marks/{id}")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] UpdateMarkDto mark)
        {
            await this.markRepository.Update(id, mark);
            return Ok();
        }

        [HttpPost]
        [Route("api/students/{studentId}/marks/subject")]
        public async Task<ActionResult> GetBySubjectName([FromRoute] int studentId, [FromBody] string name)
        {
            var subjectName = await this.markRepository.GetBySubjectName(studentId, name);

            if (subjectName is null)
            {
                throw new NullReferenceException("There is no subject with such name");
            }

            return Ok(subjectName);
        }

        [HttpPost]
        [Route("api/teachers/{teacherId}/marks/subject")]

        public async Task<ActionResult<List<GroupedMarkDto>>> GetByTeacherIdAndSubjectName([FromRoute] int teacherId, [FromBody] string subjectName)
        {
            var test = await this.markRepository.GetByTeacherIdAndSubjectName(teacherId, subjectName);
            return Ok(test);
        }
    }
}
