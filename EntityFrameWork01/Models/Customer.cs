using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;



        public Address ShipmentAddress { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();



        public ICollection<Service> Services { get; set; } = new HashSet<Service>();
        public virtual ICollection<CustomerServices> CustomerServices { get; set; } = new HashSet<CustomerServices>();
    }
}
