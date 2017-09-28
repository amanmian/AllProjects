using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string description { get; set; }
        public virtual ICollection<Author> Author { get; set; }
        
        public int AuthorId { get; set; }
   
        public ICollection<Student> Student { get; set; }
    }
}