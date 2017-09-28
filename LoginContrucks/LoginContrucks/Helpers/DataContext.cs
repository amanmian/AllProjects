using LoginContrucks.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginContrucks.Helpers
{
    public class DataContext:DbContext
    {
        public DataContext() : base("LoginString")
        {
        }


        public DbSet<User> Users { get; set; }
    }
}