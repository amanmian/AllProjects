using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class Studentcontext:DbContext
    {
        public Studentcontext() : base("name= MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }


    }
}