using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Settings:BaseEntity
    {
        public byte[]? Logo { get; set; }
        public string? SiteName { get; set; }
        public string?  Description { get; set; }
    }
}
