using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapiproject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
    }
}