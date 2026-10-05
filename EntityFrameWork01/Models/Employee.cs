using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    //POCO Class
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }//18,2 =>10,2
        //Navigational Property Car
        //Each Employee Can have Zero or one Car [Optional]
        public Car? EmployeeCar { get; set; }


        public Address HomeAddress { get; set; }


        public Employee? Manager { get; set; }
        public int? ManID { get; set; }//Recursive RelationShip



    }
}
