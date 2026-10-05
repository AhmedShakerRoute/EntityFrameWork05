using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameWork01.Models
{
  
    public class CustomerServices
    {
      
        public int CustomerId { get; set; }//FK
        public Customer Customer { get; set; }

    
        public int ServiceId { get; set; }//FK
        public Service Service { get; set; }
        public int? Cost { get; set; }
    }
}
