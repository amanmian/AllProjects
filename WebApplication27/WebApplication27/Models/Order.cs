using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication27.Models;

namespace WebApplication27.Models
{
    public class Order
    {
        public Order()
        {
            List<Product> productList = new List<Product>();
        }
        public int OrderId { get; set; }
        public int Customerid
        {
            get; set;
        }
        public ICollection<Customer> Customers{ get; set; }
        public ICollection<Product> Products { get; set; }
    }
}