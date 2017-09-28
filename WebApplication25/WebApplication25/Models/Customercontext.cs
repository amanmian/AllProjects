using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication25.Models
{

    public class Customercontext : DbContext
    {
        public Customercontext() : base("name = MyConnectionString")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ONE-TO-MANY
            modelBuilder.Entity<Customer>()
                 A..HasKey(A =>Id)
                .HasMany(B => B.Orders);
          
            /*MANY-TO-MANY
            modelBuilder.Entity<Order>()
                .HasKey(P => P.orderid)
                .HasMany(O => O.customer);

            modelBuilder.Entity<Product>()
                .HasKey(D => D.productid)
                .HasOptional(W => W.cust);



        }

        }
*/