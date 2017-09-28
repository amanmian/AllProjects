using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication27.Models
{

    public class Customercontext : DbContext
    {
        public Customercontext() : base("name = MyConnectionString")
        {
        }
        public DbSet<Customer> Customers { get; set; }
   
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /* ONE-TO-MANY
            modelBuilder.Entity<Customer>()
              
                .HasMany(B => B.Orders);

            /*MANY-TO-MANY
            modelBuilder.Entity<Order>()
                .HasKey(P => P.OrderId)
                .HasMany(O => O.Customers);

            modelBuilder.Entity<Product>()
                .HasKey(D => D.ProductId)
                .HasOptional(W => W.Customers);*/
            #region<--MCustomer-->

            #region<--Table MCustomer -->
            modelBuilder.Entity<Customer>()

                .HasKey(t => t.CustomerId)
                .HasMany(t => t.Order);
               
            #endregion

            #region<--Column CustomerId -->
            modelBuilder.Entity<Customer>()
                .Property(t => t.CustomerId)
                .HasColumnName("CustomerId");
            #endregion

            #region<--Column CustomerName -->
            modelBuilder.Entity<Customer>()
                .Property(t => t.CustomerName)
                .HasColumnName("CustomerName");
            #endregion

            #endregion

            #region<==MOrder==>

            #region<==Table MOrder==>

            modelBuilder.Entity<Order>()

                .HasKey(t => t.OrderId)
                .HasMany(t => t.Products);
             

            #endregion


            #region<--Column OrderId -->
            modelBuilder.Entity<Order>()
                .Property(t => t.OrderId)
                .HasColumnName("OrderId");
            #endregion

            #region<--Column CustomerId -->
            modelBuilder.Entity<Order>()
                .Property(t => t.Customerid)
                .HasColumnName("CustomerId");
            #endregion


            #region<==Product==>


            #region<--MProduct -->
            modelBuilder.Entity<Product>()
             
                .HasKey(t => t.ProductId);
            #endregion


            #region<--Column MProductId -->
            modelBuilder.Entity<Product>()
                .Property(t => t.ProductId)
                .HasColumnName("ProductId");
            #endregion


            #region<--Column OrderId -->
            modelBuilder.Entity<Product>()
                .Property(t => t.Orderid)
                .HasColumnName("OrderId");
            #endregion


            #region<--Column ProductName -->
            modelBuilder.Entity<Product>()
                .Property(t => t.ProductName)
                .HasColumnName("ProductName");
            #endregion


            #endregion

            #endregion





            base.OnModelCreating(modelBuilder);


        }

    }
}

