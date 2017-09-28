using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication20.Models
{
    public partial class Country
    {
        [Key]
        public int Country_id { get; set; }
        public int Id { get; set; }
        public string country { get; set; }
     
    }
}