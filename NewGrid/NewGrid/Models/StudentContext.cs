﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace NewGrid.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=student")
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}