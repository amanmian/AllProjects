using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductApp.Core;

namespace ProductApp.Infrastructure
{
   public class ProductContext:DbContext
    {
        public ProductContext()
           : base("ProductAppConnectionString")
        {
        }
        public DbSet<Product> Products { get; set; }


    }
   
}
