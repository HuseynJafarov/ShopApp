using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.SliderBox
{
    public class SliderBoxListDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public byte[]? Image { get; set; }
        public DateTime CreatedDate
        {
            get; set;
        }
    }
}
