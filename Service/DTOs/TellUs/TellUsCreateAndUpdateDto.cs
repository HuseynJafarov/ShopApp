﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.TellUs
{
    public class TellUsCreateAndUpdateDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
    }
}
