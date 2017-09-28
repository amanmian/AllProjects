using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _09.Models
{
    public class StudentContext1:DbContext
    {
        public StudentContext1() : base("name=StudentContext1")
        {

        }
        public DbSet<Student1> Students { get; set; }
        public DbSet<StudentDetalis1> StudentDetails { get; set; }
       
    }
}