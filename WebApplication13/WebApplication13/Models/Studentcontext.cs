using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class Studentcontext:DbContext
    {
        

        

            public Studentcontext() : base("name= MyConnectionString")
            {

            }
            public DbSet<Student> Students { get; set; }
        }
    }
