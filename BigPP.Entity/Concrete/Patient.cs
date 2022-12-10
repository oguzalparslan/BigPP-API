using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.Entity.Concrete
{
    public class Patient : BaseEntity
    {
        public string PatientName { get; set; }
        
        /// <summary>
        /// Hastalığa sahip olan kişilerin tutulduğu liste
        /// </summary>
        public ICollection<User> Patients{ get; set; }
    }
}
