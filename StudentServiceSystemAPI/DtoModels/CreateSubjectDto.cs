using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.DtoModels
{
    public class CreateSubjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int WeekDaysId { get; set; }
        public int ScheduleId { get; set; }
        public int ECTS { get; set; }
        public string Type { get; set; }
        public int TeacherId { get; set; }
    }
}
