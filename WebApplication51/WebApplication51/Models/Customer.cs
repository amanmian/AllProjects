using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication51.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public CustomerDetail customerdetails { get; set; }
     
      
    }
}