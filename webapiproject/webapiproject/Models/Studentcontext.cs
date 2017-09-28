using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapiproject.Models
{
   
         public class Studentcontext:DbContext
   {
       public DbSet<Student> Students { get; set; }

   }
    }
