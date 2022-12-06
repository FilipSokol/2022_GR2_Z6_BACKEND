using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.RegularExpressions;

namespace StudentServiceSystemAPI.Controllers
{
    [Route("api/subjects")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly IMapper mapper;

        public SubjectController(ISubjectRepository subjectRepository, IMapper mapper)
        {
            this.subjectRepository = subjectRepository;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get Subject by id")]
        public async Task<ActionResult<Subject>> GetById([FromRoute] int id)
        {
            var subject = await this.subjectRepository.GetById(id);

            var subjectDto = this.mapper.Map<SubjectDto>(subject);

            return Ok(subjectDto);
        }
        [HttpGet]
        [SwaggerOperation(Summary = "Get all subjects")]
        public async Task<ActionResult<List<Subject>>> GetAll()
        {
            var subjects = await this.subjectRepository.GetAll();

            var subjectsDto = this.mapper.Map<List<SubjectDto>>(subjects);
            return Ok(subjectsDto);
        }

        [HttpGet("{studentId}/student")]
        [SwaggerOperation(Summary = "Get all student subjects with marks")]
        public async Task<ActionResult<List<SubjectWithMarksDto>>> GetAllWithMarksByStudentId([FromRoute] int studentId)
        {
            var subjects = await this.subjectRepository.GetAllWithMarksByStudentId(studentId);

            return Ok(subjects);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create subject")]
        public async Task<ActionResult<int>> Create([FromBody]CreateSubjectDto dto)
        {
            var id = await this.subjectRepository.Create(dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete subject")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            await this.subjectRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update subject")]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody]SubjectDto dto)
        {
            await this.subjectRepository.Update(id, dto);
            return Ok();
        }
    }
}
