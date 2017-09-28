using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [Display (Name="Name")]
        public string Name { get; set; }
        public string Date_of_Birth { get; set; }

   
        public string MembershipType { get; set; }

        
        

    }
}