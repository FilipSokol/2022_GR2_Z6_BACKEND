﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;
using System.Runtime.CompilerServices;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/teacher")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;
        private readonly IMapper mapper;
        public TeacherController(ITeacherRepository teacherRepository, IMapper mapper)
        {
            this.teacherRepository = teacherRepository;
            this.mapper = mapper;
        }

        [HttpGet("/api/teachers/{id}")]
        public async Task<ActionResult<TeacherDto>> GetById([FromRoute] int id)
        {
            var teacher = await teacherRepository.GetById(id);
            var teacherDto = this.mapper.Map<TeacherDto>(teacher);
            return Ok(teacherDto);
        }

        [HttpGet]
        public async Task<ActionResult<List<TeacherDto>>> GetAll()
        {
            var teachers = await this.teacherRepository.GetAll();

            var teachersDto = this.mapper.Map<List<TeacherDto>>(teachers);
            return Ok(teachersDto);
        }

        [HttpGet]
        [Route("/api/departments/{departmentId}/teachers")]
        public async Task<ActionResult<List<Student>>> GetByDepartmentId([FromRoute] int departmentId)
        {
            var teachers = await this.teacherRepository.GetByDepartmentId(departmentId);
            var teachersDto = this.mapper.Map<List<TeacherDto>>(teachers);
            return Ok(teachersDto);
        }
        [HttpPost]
        [Route("/api/departments/{departmentId}/teachers")]
        public async Task<ActionResult<int>> Create([FromRoute] int departmentId, [FromBody] CreateTeacherDto dto)
        {
            var id = await this.teacherRepository.Create(departmentId, dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await this.teacherRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateTeacherDto student)
        {
            await this.teacherRepository.Update(id, student);
            return Ok();
        }

        [HttpPost]
        [Route("{teacherId}/subject/{subjectId}/assign")]
        public async Task<IActionResult> AssignSubject(int teacherId, int subjectId)
        {
            await this.teacherRepository.AssignSubject(teacherId, subjectId);

            return Ok();
        }

        [HttpPost]
        [Route("{teacherId}/subject/{subjectId}/unassign")]
        public async Task<IActionResult> UnassignSubject(int teacherId, int subjectId)
        {
            await this.teacherRepository.UnassignSubject(teacherId, subjectId);
            return Ok();
        }
    }
}
