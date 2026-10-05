using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWork01.Models
{
    internal class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        //Each Car is Owned by One Employee [Mandatory]
        public Employee CarOwner { get; set; } = default!;
        //Foreign Key //4
        //1. With The Same Type Of Navigational Property + Id EmployeeId ,
        //2. With The Same Type Of Navigational Property + PK EmployeeEmpId ,
        //3. With The Same Type Of  Property + Id CarOwnerId 
        //4. With The Same Type Of  Property + Id CarOwnerEmpId

        [ForeignKey(nameof(CarOwner))]
        public int EmployeeId { get; set; }
    

    }
}
