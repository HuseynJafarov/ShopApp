using Domain.Entities;


namespace Service.DTOs.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? Position { get; set; }
    }
}
