using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BigPP.DataAccess.SeedData
{
    public class AdminSeed : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
                new Admin { Id = 1, Identity = Guid.NewGuid(), AdminName = "OguzAlpArsln", AdminPhone = "05332872239", CreatedDate = DateTime.Now },
                new Admin { Id = 2, Identity = Guid.NewGuid(), AdminName = "OguzAlpArsln2", AdminPhone = "05332872239", CreatedDate = DateTime.Now },
                new Admin { Id = 3, Identity = Guid.NewGuid(), AdminName = "OguzAlpArsln3", AdminPhone = "05332872239", CreatedDate = DateTime.Now }
                );
        }
    }
}
