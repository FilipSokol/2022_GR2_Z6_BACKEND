namespace StudentServiceSystemAPI.DtoModels
{
    public class UpdateTeacherDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int SubjectId { get; set; }

        public int DepartmentId { get; set; }
    }
}
