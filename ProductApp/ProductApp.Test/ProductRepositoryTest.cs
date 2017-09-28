using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Test
{
    [TestClass]
   public  class ProductRepositoryTest
    {
        ProductRepository Repo;
            
        [TestInitialize]
        public void TestSetup()
        {
            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ProductRepository();
        }
    }
}
