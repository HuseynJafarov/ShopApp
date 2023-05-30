using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student: BaseEntity
    {
        public string? FullName { get; set; }
        public byte[]? Image { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CartId { get; set; }
        public Carts? Carts { get; set; }
    }
}
