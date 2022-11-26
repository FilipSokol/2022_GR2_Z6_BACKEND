namespace StudentServiceSystemAPI.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public List<Subject> Subjects { get; set; }
        public virtual Group Group { get; set; }
    }
}
