using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{

    public class UserContext : DbContext
    {
        public UserContext()
           : base("name=MyConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<State> Profiles { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
    }
