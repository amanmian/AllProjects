using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Member.Core
{
   public class MemberApp
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
       [Required]
        public bool MaritalStatus { get; set; }

        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }


    }
}
