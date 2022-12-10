using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.Entity.Concrete
{
    public class Doctor : BaseEntity
    {
        public string DoctorName{ get; set; }
        public string DoctorRegistrationNumber{ get; set; }
        public string DoctorWorkingAt{ get; set; }
        public string DoctorPhone{ get; set; }
    }
}
