using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.Entity.Concrete
{
    public class Family : BaseEntity
    {
        public string FamilyName { get; set; }
        public string FamilyNumber { get; set; }
        public int FamilySize { get; set; }
        public User UserId { get; set; }
        public ICollection<FamilyMember> FamilyMemberList { get; set; }

    }
}
