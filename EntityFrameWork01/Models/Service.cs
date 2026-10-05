using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();

        public ICollection<CustomerServices> CustomerServices { get; set; } = new HashSet<CustomerServices>();
    }
}
