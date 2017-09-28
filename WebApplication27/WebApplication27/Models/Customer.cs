using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication27.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Product> product { get; set;}
  
        public virtual ICollection<Order> Order { get; set; }
    }
}