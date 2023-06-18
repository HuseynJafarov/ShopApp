using Domain.Entities;


namespace Service.DTOs.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<string>? CartsTitle { get; set; }
        public string? BlogTitle { get; set; }
        public string? Image { get; set; }
    }
}
