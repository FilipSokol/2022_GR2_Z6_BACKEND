namespace StudentServiceSystemAPI.DtoModels
{
    public class MarkDto
    {
        public int MarkId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int? SubjectId { get; set; }
        public string Description { get; set; }
        public int StudentId { get; set; }
        public double MarkValue { get; set; }
    }
}
