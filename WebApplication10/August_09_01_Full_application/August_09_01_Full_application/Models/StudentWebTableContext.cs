using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace August_09_01_Full_application.Models
{
    public class StudentWebTableContext:DbContext
    {
        public StudentWebTableContext() :base("name=StudentWebTableContext")
        {

        }
        public DbSet<StudentWebTable> student0002 { get; set; }
        public DbSet<StudentDetailsWebTable> studentdetail0002 { get; set; }
       
    }
}