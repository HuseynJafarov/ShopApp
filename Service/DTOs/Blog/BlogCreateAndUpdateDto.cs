using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Blog
{
    public class BlogCreateAndUpdateDto
    {

        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public int AuthorId { get; set; }
    }
}
