using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Student
{
    public class StudentListDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public byte[]? Image { get; set; }
        public string? Info { get; set; }
        public bool IsGraduated { get; set; }
        public int CartId { get; set; }
        public Carts? Carts { get; set; }
    }
}
