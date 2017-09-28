using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
       
        public string length { get; set; }
    }
}