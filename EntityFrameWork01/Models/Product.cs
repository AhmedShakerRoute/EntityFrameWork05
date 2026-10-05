using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    //Model | Entity | POCO Class | Domain Class
    internal class Product
    {
        public int Id { get; set; } //Primary Key  + Identity Constrain          Id // ProductId //Integeral
        public string?  Name { get; set; } // nulllable Reference Type // nullable string => nvarchar(max) allow null
        public decimal Price { get; set; }//non nullable value type => Mapped as Decimal(18 , 2); 
        public int UnitInStock { get; set; } // ValueType -- Non Nullable Value Type // int not null
    }
}
