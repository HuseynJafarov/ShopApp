using Domain.Entities;
using Service.DTOs.Cart;

namespace Service.DTOs.Student
{
    public class StudentListDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Image { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public string? CartTitle { get; set; }
    }
}
