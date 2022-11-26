using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Models;
using StudentServiceSystemAPI.Repositories;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/schedules")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleRepository scheduleRepository;
        private readonly IMapper mapper;

        public ScheduleController(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            this.scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        [HttpGet("{groupId}")]
        public async Task<ActionResult<Schedule>> GetById([FromRoute] int groupId)
        {
            var schedule = await this.scheduleRepository.GetById(groupId);

            return Ok(schedule);
        }
        [HttpPost]
        [Route("{groupId}/period")]
        public async Task<ActionResult<List<Schedule>>> GetPeriod([FromRoute] int groupId, [FromBody] GetPeriodDto period)
        {
            var schedules = await this.scheduleRepository.GetPeriod(groupId, period);
   
            return Ok(schedules);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] ScheduleDto dto)
        {
            var id = await this.scheduleRepository.Create(dto);
            return Created($"/api/department/{id}", null);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await this.scheduleRepository.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] ScheduleDto dto)
        {
            await this.scheduleRepository.Update(id, dto);
            return Ok();
        }
    }
}
