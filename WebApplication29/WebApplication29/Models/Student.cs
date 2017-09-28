using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string division { get; set; }
        public string Email { get; set; }
    }
}