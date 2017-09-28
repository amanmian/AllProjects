using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Webapi1.Models
{
    public class MemberContext:DbContext
    {
        public MemberContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Member> Members { get; set; }
    }
}