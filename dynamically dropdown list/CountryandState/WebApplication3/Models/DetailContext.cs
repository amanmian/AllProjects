using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class DetailContext:DbContext
    {
        public DetailContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Detail> Details { get; set; }
        public DbSet<State> Infos { get; set; }
        public DbSet<Country> Infi { get; set; }

        public System.Data.Entity.DbSet<WebApplication3.Models.DetailVM> DetailVMs { get; set; }
    }
}