namespace StudentServiceSystemAPI.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public double MarkValue { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
