using Member.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member.Core.Interface;

namespace Member.Infra
{
   public  class MemberAppRepository:IMemberAppRepository
    {
        MemberRepository context = new MemberRepository();

        public void Add(MemberApp p)
        {
            context.MemberApps.Add(p);
            context.SaveChanges();
        }
        public void Edit(MemberApp p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }
        public MemberApp FindById(int Id)
        {
            var result = (from r in context.MemberApps where r.Id == Id select r).FirstOrDefault();
            return result;
        }
        public IEnumerable GetMembers()
        {
            return context.MemberApps;
        }

        public void Remove(int Id)
        {
           MemberApp p = context.MemberApps.Find(Id);
            context.MemberApps.Remove(p);
            context.SaveChanges();
        }
    }
}
