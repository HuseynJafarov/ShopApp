using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Account
{
    public class ChangePasswordDto
    {
        public string? Password { get; set; }
        public string? NewPassword { get; set; }
    }
}
