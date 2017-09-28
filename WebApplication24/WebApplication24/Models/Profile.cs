using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Profile
    {
        public int stuid { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }
        public int age { get; set; }
        public Student student { get; set; }
    }
}