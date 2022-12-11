using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BigPP.DataAccess.Configurations
{
    public class NurseConfiguration : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.NurseName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.NursePhone).IsRequired().HasMaxLength(11);

            builder.ToTable("Nurses");
        }
    }
}
