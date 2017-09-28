using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Profile Profile { get; set; }
      
        public virtual ICollection<Course> Course { get; set; }

    }
}