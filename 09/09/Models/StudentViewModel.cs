using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _09.Models
{
    public class StudentViewModel
    {
        [Key]
        public int Id { get; set; }
        public Student1 Student { get; set; }
        public IEnumerable <StudentDetalis1> StudentDetalis { get; set; }
    }
}