using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class Customercontext:DbContext
     
    {
    public Customercontext(): base("name=MyConnectionString")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> Membershiptypes { get; set; }
    }
}