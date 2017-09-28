using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _09.Models
{
    public class Student1
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public StudentDetalis1 studentdetails { get; set; }
    }
}