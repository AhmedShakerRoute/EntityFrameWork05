using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Credits { get; set; }
        public DateTime CourseTime { get; set; }
    }
}
