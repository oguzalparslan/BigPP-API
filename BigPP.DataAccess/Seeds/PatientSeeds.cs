using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.Seeds
{
    public class PatientSeeds : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
                new Patient { Id = 1, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, PatientName = "Patient" },
                new Patient { Id = 2, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, PatientName = "Patient2" },
                new Patient { Id = 3, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, PatientName = "Patient3" }
                );
        }
    }
}
