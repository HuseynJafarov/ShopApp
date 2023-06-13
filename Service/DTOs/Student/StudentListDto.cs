using Domain.Entities;
using Service.DTOs.Cart;

namespace Service.DTOs.Student
{
    public class StudentListDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public byte[]? Image { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CartId { get; set; }
        public CartListDto? CartsList { get; set; }
    }
}
