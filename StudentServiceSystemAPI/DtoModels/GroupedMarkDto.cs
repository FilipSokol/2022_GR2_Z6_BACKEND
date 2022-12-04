namespace StudentServiceSystemAPI.DtoModels
{
    public class GroupedMarkDto
    {
        public int StudentId { get; set; }

        public List<MarkDto> Marks { get; set; }
    }
}
