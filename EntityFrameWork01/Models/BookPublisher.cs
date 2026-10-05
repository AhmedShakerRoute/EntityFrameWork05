using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameWork01.Models
{
    internal class BookPublisher
    {
        //FK To Book RelationShip
        public int BookId { get; set; } 
        public Book Book { get; set; }
        [Key]
        public int PublisherId { get; set; } //FK
        public Publisher Publisher { get; set; }

    }
}
