using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication20.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString= "{0:yyyy-MM-dd}")]
        public DateTime Birthday { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}