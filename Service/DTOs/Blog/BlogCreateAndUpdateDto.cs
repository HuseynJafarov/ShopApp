using Microsoft.AspNetCore.Http;

namespace Service.DTOs.Blog
{
    public class BlogCreateAndUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile Photo { get; set; }
        public int AuthorId { get; set; }
    }
}
