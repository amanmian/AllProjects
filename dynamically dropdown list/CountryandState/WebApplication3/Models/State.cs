using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public partial class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}