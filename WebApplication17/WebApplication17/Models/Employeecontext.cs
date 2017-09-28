using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Employeecontext:DbContext

    {
       
        
            public Employeecontext() : base("name = MyConnectionString")
            {
            }
            public DbSet<Employee> Employees { get; set; }

           

        }
    }