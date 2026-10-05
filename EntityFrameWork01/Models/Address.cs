using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    [Owned]
    public class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
