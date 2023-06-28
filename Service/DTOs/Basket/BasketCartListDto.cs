using Service.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Basket
{
    public class BasketCartListDto
    {
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public int BasketId { get; set; }
        public CartListDto Cart { get; set; }
    }
}
