using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
     
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}