using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.Entity.Concrete
{
    public class Visitor : BaseEntity 
    {
        public string VisitorName { get; set; }
        public string VisitorPhone{ get; set; }
        public User UserId{ get; set; }
    }
}
