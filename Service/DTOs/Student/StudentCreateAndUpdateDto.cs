using Microsoft.AspNetCore.Http;

namespace Service.DTOs.Student
{
    public class StudentCreateAndUpdateDto
    {
        public string? FullName { get; set; }
        public string? Info { get; set; }
        public int CartId { get; set; }
        public bool IsGraduated { get; set; } = false;
        public IFormFile Photo { get; set; }
    }
}
