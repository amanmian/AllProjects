using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class MyDrop
    {
        [Key]
        public string email { get; set; }
       
        public string state { get; set; }
    }
}