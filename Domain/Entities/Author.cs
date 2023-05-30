using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public byte[]? Image { get; set; }
        public string? Position { get; set; }
        public ICollection<CartAuthor>? CartAuthors { get; set; }
    }
}
