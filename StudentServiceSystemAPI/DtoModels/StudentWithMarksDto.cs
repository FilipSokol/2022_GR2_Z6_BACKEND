namespace StudentServiceSystemAPI.DtoModels
{
    public class StudentWithMarksDto
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<MarkDto> Marks { get; set; }
    }
}
