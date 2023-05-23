using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Services
{
    public class ServicesListDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
