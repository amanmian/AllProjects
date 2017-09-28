using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace August_09_01_Full_application.Models
{
    public class StudentWebTable
    {
        [Key]
        public int Stud_id { get; set; }
        public string Stud_fname { get; set; }
        public string Stud_lname { get; set; }
        public int Stud_std { get; set; }
        public string Stud_group { get; set; }
        public string Stud_cousre { get; set; }
        public int age { get; set; }
        public StudentDetailsWebTable studentdetails0002 { get; set; }

    }
}