using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name= MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }


    }
}
