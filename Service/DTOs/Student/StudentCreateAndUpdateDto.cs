using Microsoft.AspNetCore.Http;

namespace Service.DTOs.Student
{
    public class StudentCreateAndUpdateDto
    {
        public string? FullName { get; set; }
        public IFormFile Photo { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CartId { get; set; }
    }
}
