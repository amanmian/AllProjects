using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication51.Models
{
    public class Context : DbContext
    {
       public Context() : base("name=MyConnectionString")
        {

        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerDetail> customerdetails { get; set; }

      
   

    }
}