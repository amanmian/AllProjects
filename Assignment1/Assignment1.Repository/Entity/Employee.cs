using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository.Entity
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public bool MaritalStatus { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
