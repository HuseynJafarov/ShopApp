

namespace Service.DTOs.Blog
{
    public class BlogListDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? AuthorName { get; set; }
        public string? Image { get; set; }
    }
}
