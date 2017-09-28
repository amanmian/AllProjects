using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace August_09_01_Full_application.Models
{
    public class StudentDetailsWebTable
    {   
        [Key]
        public int Stud_addr_id { get; set; }
        public string Stud_area { get; set; }
        public string Stud_street { get; set; }
        public string Stud_city { get; set; }
        public string Stud_zipcode { get; set; }

    }
}