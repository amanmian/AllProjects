using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{


    public class Studentcontext : DbContext
    {
        public Studentcontext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Studentdetails> stud { get; set; }
        public DbSet<Studentviewmodel> stud1 { get; set; }
    }
}