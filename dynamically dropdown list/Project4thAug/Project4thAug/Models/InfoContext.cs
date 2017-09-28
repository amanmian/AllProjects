using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project4thAug.Models
{
    public class InfoContext : DbContext
    {
        public InfoContext() : base("name=InfoContext")
        {

        }
        public DbSet<Information> InfoList
        {
            get; set;
        }
        public DbSet<States> StateList
        {
            get; set;
        }
        public DbSet<Cities> CityList
        {
            get; set;
        }
    }
}