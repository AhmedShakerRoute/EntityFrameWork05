using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    internal class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        //public Book? Book { get; set; }
        public BookPublisher? BookPublisher { get; set; }

    }
}
