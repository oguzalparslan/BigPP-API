using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.DoctorName).IsRequired();
            builder.Property(x => x.DoctorRegistrationNumber).IsRequired();
            builder.Property(x => x.DoctorWorkingAt).IsRequired();

            builder.ToTable("Doctors");
        }
    }
}
