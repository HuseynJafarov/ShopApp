using Domain.Common;


namespace Domain.Entities
{
    public class Student: BaseEntity
    {
        public string? FullName { get; set; }
        public byte[]? Image { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CartId { get; set; }
        public Carts? Carts { get; set; }
    }
}
