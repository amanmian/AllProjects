using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class Personcontext: DbContext
    {


        public Personcontext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}