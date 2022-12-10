using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.Entity.Concrete
{
    public class User : BaseEntity
    {
        public string  UserName{ get; set; }
        public Family familyId{ get; set; }
    }
}
