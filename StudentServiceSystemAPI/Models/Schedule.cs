namespace StudentServiceSystemAPI.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public List<WeekDays> WeekDays { get; set; }
        public virtual Group Group { get; set; }
    }
}
