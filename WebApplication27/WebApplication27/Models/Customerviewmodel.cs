using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.Models
{
    public class Customerviewmodel
    {
        [Key]
        public int id { get; set; }
        public List<Product> products { get; set; }
        public List<Order> orders { get; set; }
        public Customer customers { get; set; }
    }
}