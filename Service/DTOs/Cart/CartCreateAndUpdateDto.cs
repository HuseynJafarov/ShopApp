using Microsoft.AspNetCore.Http;


namespace Service.DTOs.Cart
{
    public class CartCreateAndUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile Photo { get; set; }
        public double Price { get; set; }
        public List<int>? AuthorIds { get; set; }
    }

}
