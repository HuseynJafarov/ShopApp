using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? Position { get; set; }
        public ICollection<CartAuthor>? CartAuthors { get; set; }
    }
}
