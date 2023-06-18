using Microsoft.AspNetCore.Http;

namespace Service.DTOs.Author
{
    public class AuthorCreateAndUpdateDto
    {
        public string? Name { get; set; }
        public IFormFile Photo { get; set; }
        public string? Position { get; set; }
        //public List<int>? CartIds { get; set; }
    }
}
