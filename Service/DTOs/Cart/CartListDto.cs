using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Cart
{
    public class CartListDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image{ get; set; }
        public double Price { get; set; }
        public List<string>? AuthorName { get; set; }

    }
}
