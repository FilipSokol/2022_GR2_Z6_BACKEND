using System.ComponentModel.DataAnnotations;

namespace StudentServiceSystemAPI.DtoModels
{
    public class CreateDepartmentDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
