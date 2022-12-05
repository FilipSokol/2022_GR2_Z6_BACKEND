using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.DtoModels
{
    public class SubjectDto
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; } = nameof(SubjectType.Unknown);
        public int ScheduleId { get; set; }
        public int ECTS { get; set; }
        public int TeacherId { get; set; }
    }
}
