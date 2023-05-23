using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.SliderBox
{
    public class SliderBoxCreateAndUpdateDto
    {
        public string? Title { get; set; }
        public byte[] Image { get; set; }
    }
}
