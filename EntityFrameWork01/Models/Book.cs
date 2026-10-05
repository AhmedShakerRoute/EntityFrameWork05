using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookPublisher> BookPublisher  { get; set; }
    }
}
