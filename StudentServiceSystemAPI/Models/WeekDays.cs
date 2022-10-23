namespace StudentServiceSystemAPI.Models
{
    public class WeekDays
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ScheduleId { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
