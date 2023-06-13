using Domain.Common;


namespace Domain.Entities
{
    public class Carts:BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public double Price { get; set; }
        public ICollection<CartAuthor>? CartAuthors { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
