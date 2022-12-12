using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.SeedData
{
    public class DoctorSeeds : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                new Doctor { Id = 1, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, DoctorName = "oguzalparsln", DoctorPhone = "123456789", DoctorRegistrationNumber = "123123123", DoctorWorkingAt = "çankırı dh" },
                new Doctor { Id = 2, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, DoctorName = "oguzalparsln2", DoctorPhone = "123456789", DoctorRegistrationNumber = "123123123", DoctorWorkingAt = "çankırı dh" },
                new Doctor { Id = 3, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, DoctorName = "oguzalparsln3", DoctorPhone = "123456789", DoctorRegistrationNumber = "123123123", DoctorWorkingAt = "çankırı dh" }
                );
        }
    }
}
