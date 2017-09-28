using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication27.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductName { get; set; }
        public int Orderid { get; set; }
        public ICollection<Order> Orders
        {
            get; set;
        }
        public ICollection<Customer> Customers { get; set; }
    }
}