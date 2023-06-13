using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Cart
{
    public class CartCreateAndUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile Photo { get; set; }
        public double Price { get; set; }
    }

}
