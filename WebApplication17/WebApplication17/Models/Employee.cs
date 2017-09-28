using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Employee
    {
        public int Id { get; set; }
  
        [Max18]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthday { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Office { get; set; }
        [Min18]
        public int Age { get; set; }



    }
}



       




    