using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EntityFrameWork01.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer OrderCustomer { get; set; } = default!;
    }
}
