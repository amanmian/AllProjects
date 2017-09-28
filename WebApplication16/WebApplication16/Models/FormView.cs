using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class FormView
    {
        [Key]
        public int id { get; set; }
        public IEnumerable<MyDrop> List { get; set; }
        public Customer customer { get; set; }
    }
}