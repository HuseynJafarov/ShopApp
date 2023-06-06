using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Setting
{
    public class SettingCreateAndUpdateDto
    {
        public byte[]? Logo { get; set; }
        public string? SiteName { get; set; }
        public string? Description { get; set; }
    }
}
