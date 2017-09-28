using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Repository.Entity
{
   public  class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Phone { get; set; }
      
        public bool MaritalStatus { get; set; }
       
        public string State { get; set; }
       
        public string City { get; set; }
        public string length { get; set; }
    }
}
