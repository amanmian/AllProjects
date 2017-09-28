using _09.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _09.Dto
{
    public class StudentDto
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public StudentsDetailsDto studentdetails { get; set; }

       
    }
}