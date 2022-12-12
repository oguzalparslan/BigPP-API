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
    public class FamilyMemberSeeds : IEntityTypeConfiguration<FamilyMember>
    {
        public void Configure(EntityTypeBuilder<FamilyMember> builder)
        {
            builder.HasData(
                new FamilyMember { Id = 1, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "FamilyMember", PhoneNumber = "123456789", Surname = "Surname", FamilyId = 1 },
                new FamilyMember { Id = 2, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "FamilyMember2", PhoneNumber = "123456789", Surname = "Surname2", FamilyId = 2 },
                new FamilyMember { Id = 3, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "FamilyMember3", PhoneNumber = "123456789", Surname = "Surname3", FamilyId = 3 }
                );
        }
    }
}
