using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Student
    {
        public int id { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public string ConPassword { get; set; }
    }
}