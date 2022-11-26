namespace StudentServiceSystemAPI.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ECTS { get; set; }
        public int? ScheduleId { get; set; }
        public int? TeacherId { get; set; }
        public SubjectType Type { get; set; } = SubjectType.Unknown;
        public virtual Teacher Teacher { get; set; }
        public List<Mark> Marks { get; set; }

    }
}
