using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SliderBoxs:BaseEntity
    {
        public string? Title { get; set; }
        public byte[] Image { get; set; }
    }
}
