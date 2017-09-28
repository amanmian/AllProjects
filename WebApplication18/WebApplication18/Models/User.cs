using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}