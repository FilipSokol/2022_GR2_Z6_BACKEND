using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;
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
        [Route("api/students/{studentId}/marks/{markId}")]
        [SwaggerOperation(Summary = "Get Mark by {studentId} and {markId}")]
        public async Task<ActionResult<Mark>> GetById([FromRoute] int studentId, [FromRoute]int markId)
        {
            var mark = await this.markRepository.GetById(studentId, markId);
            return Ok(mark);
        }

        [HttpGet]
        [Route("api/students/{studentId}/marks")]
        [SwaggerOperation(Summary = "Get all marks of student with {studentId}")]
        public async Task<ActionResult<List<Mark>>> GetAll([FromRoute] int studentId)
        {
            var marks = await this.markRepository.GetAll(studentId);
            return Ok(marks);
        }
        [HttpPost]
        [Route("api/students/{studentId}/marks")]
        [SwaggerOperation(Summary = "Add mark to student {studentId}")]
        public async Task<ActionResult<int>> Create([FromRoute] int studentId, [FromBody] CreateMarkDto dto)
        {
            var id = await this.markRepository.Create(studentId, dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete]
        [Route("api/students/{studentId}/marks/{markId}")]
        [SwaggerOperation(Summary = "Delete mark {markId}")]
        public async Task<ActionResult> Delete([FromRoute] int markId)
        {
            await this.markRepository.Delete(markId);
            return NoContent();
        }
        [HttpPut]
        [Route("api/students/{studentId}/marks/{id}")]
        [SwaggerOperation(Summary = "Update students mark.")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] UpdateMarkDto mark)
        {
            await this.markRepository.Update(id, mark);
            return Ok();
        }

        [HttpPost]
        [Route("api/students/{studentId}/marks/subject")]
        [SwaggerOperation(Summary = "Get marks by subject name")]
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
        [SwaggerOperation(Summary = "Get marks by {teacherId} and Subject Name")]
        public async Task<ActionResult<List<GroupedMarkDto>>> GetByTeacherIdAndSubjectName([FromRoute] int teacherId, [FromBody] string subjectName)
        {
            var test = await this.markRepository.GetByTeacherIdAndSubjectName(teacherId, subjectName);
            return Ok(test);
        }
    }
}
