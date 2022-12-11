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
    public class DispensaryConfiguration : IEntityTypeConfiguration<Dispensary>
    {
        public void Configure(EntityTypeBuilder<Dispensary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.DispensaryName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.DispensaryPhone).IsRequired().HasMaxLength(11);
            builder.Property(x => x.DispensaryAddress).IsRequired().HasMaxLength(500);

            builder.ToTable("Dispensaries");
        }
    }
}
