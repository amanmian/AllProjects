using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DetailVM
    {
        public int Id { get; set; }
        public Detail detail { get; set; }
        public IEnumerable<State> List { get; set; }
        public IEnumerable<Country> List2 { get; set; }
    }
}