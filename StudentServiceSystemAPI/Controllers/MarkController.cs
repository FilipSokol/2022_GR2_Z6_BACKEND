﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<int>> Create([FromBody] Mark mark)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromRoute]int id, [FromBody] Mark mark)
        {
            throw new NotImplementedException();
        }
    }
}
