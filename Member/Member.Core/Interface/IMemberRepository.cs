using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Member.Core.Interface
{
   public interface IMemberAppRepository
    {
        void Add(MemberApp p);
        void Edit(MemberApp p);
        void Remove(int Id);
        IEnumerable GetMembers();
        MemberApp FindById(int Id);

    }
}
