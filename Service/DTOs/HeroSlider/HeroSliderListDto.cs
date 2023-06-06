using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.HeroSlider
{
    public class HeroSliderListDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public string? Student { get; set; }
        public string? StudentStatus { get; set; }
    }
}
