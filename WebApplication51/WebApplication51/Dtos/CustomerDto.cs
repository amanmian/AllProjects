using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication51.Dtos
{
    public class CustomerDto
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public CustomerDetailDto customerdetails { get; set; }
    }
}