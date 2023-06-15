using Domain.Entities;


namespace Service.DTOs.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Position { get; set; }
        public List<string>? CartName { get; set; }
        public string? BlogName { get; set; }
    }
}
