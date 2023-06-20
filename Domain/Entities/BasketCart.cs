

using Domain.Common;

namespace Domain.Entities
{
    public class BasketCart:BaseEntity
    {
        public int Quantity { get; set; }
        public int BasketId { get; set; }
        public Basket? Basket { get; set; }
        public int CartId { get; set; }
        public Carts? Cart { get; set; }
    }
}
