using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HeroSliders:BaseEntity
    {
        public string? Description { get; set; }
        public byte[] Image { get; set; }
        public string? Student { get; set; }
        public string? StudentStatus { get; set; }
    }
}
