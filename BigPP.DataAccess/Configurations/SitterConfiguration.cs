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
    public class SitterConfiguration : IEntityTypeConfiguration<Sitter>
    {
        public void Configure(EntityTypeBuilder<Sitter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.SitterName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SitterPhone).IsRequired().HasMaxLength(11);

            builder.ToTable("Sitters");
        }
    }
}
