﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Events:BaseEntity
    {
        public string? Title { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
    }
}
