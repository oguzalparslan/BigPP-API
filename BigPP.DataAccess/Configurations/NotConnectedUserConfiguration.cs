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
    public class NotConnectedUserConfiguration : IEntityTypeConfiguration<NotConnectionUser>
    {
        public void Configure(EntityTypeBuilder<NotConnectionUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();

            builder.ToTable("NotConnectionUsers");
        }
    }
}
