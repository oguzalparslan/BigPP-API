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
    public class FamilySeeds : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.HasData(
                new Family { Id=1,CreatedDate=DateTime.Now,Identity=Guid.NewGuid(),FamilyName="FamilyName",FamilyNumber="123",FamilySize=4,UserId=1},
                new Family { Id=2,CreatedDate=DateTime.Now,Identity=Guid.NewGuid(),FamilyName="FamilyName2",FamilyNumber="123",FamilySize=4,UserId=2},
                new Family { Id=3,CreatedDate=DateTime.Now,Identity=Guid.NewGuid(),FamilyName="FamilyName3",FamilyNumber="123",FamilySize=4,UserId=3}
                );
        }
    }
}
