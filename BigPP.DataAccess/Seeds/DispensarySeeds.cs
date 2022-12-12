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
    public class DispensarySeeds : IEntityTypeConfiguration<Dispensary>


    {
        public void Configure(EntityTypeBuilder<Dispensary> builder)
        {
            builder.HasData(

                new Dispensary { Id = 1, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), DispensaryAddress = "çankırı", DispensaryName = "çankırı dh", DispensaryPhone = "123456879" },
                new Dispensary { Id = 2, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), DispensaryAddress = "çankırı", DispensaryName = "çankırı asm1", DispensaryPhone = "123456879" },
                new Dispensary { Id = 3, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), DispensaryAddress = "çankırı", DispensaryName = "çankırı asm2", DispensaryPhone = "123456879" });
        }
    }
}
