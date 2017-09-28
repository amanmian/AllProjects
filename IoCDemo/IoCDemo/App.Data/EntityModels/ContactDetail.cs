using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.EntityModels
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        public string TwitterAlias { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string Messenger { get; set; }
        public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
    }
}
