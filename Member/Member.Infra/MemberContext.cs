using Member.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infra
{
   public  class MemberRepository:DbContext
    {
        public MemberRepository():base("MemberTest")
        {

        }
        public DbSet<MemberApp> MemberApps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Week_6");
        }
    }
}
