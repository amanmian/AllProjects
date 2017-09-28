using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{
    public class Userviewmodel
    {

        [Key]
        public int id { get; set; }
        public IEnumerable<State> List { get; set; }
        public IEnumerable<Country> List1 { get; set; }
        public User user { get; set; }
    }
}