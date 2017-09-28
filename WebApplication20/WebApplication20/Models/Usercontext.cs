using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication20.Models
{
    public class Usercontext:DbContext
    {
        public Usercontext()
           : base("name=MyConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        public System.Data.Entity.DbSet<WebApplication20.Models.Userviewmodel> Userviewmodels { get; set; }

    }
}