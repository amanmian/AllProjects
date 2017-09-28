using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{
    public class Studentviewmodel
    {
        public int Id { get; set; }

        public int StuId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string division { get; set; }
        public string Email { get; set; }
        public long phone { get; set; }
        public string FathersName { get; set; }
        public string Address { get; set; }
    }
}