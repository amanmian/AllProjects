using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project4thAug.Models
{
    public class Information
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool MariStatus { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }

    }
}