using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace August_09_01_Full_application.Dtos
{
    public class StudentDetailsDto
    {
        [Key]
        public int Stud_addr_id { get; set; }
        public string Stud_area { get; set; }
        public string Stud_street { get; set; }
        public string Stud_city { get; set; }
        public string Stud_zipcode { get; set; }
    }
}