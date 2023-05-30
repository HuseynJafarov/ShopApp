using Domain.Common;


namespace Domain.Entities
{
    public class Events:BaseEntity
    {
        public string? Title { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public DateTime EventDate { get; set; }
    }
}
