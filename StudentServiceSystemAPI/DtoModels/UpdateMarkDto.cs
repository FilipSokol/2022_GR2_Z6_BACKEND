namespace StudentServiceSystemAPI.DtoModels
{
    public class UpdateMarkDto
    {
        public DateTime DateOfIssue { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public double MarkValue { get; set; }
    }
}
