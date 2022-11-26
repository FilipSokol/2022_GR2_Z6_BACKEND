namespace StudentServiceSystemAPI.DtoModels
{
    public class UpdateStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int GroupId { get; set; }
    }
}
