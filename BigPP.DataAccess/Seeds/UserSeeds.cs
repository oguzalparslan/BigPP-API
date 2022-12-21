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
    public class UserSeeds : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), UserName = "User 1", FamilyId = 1 },
                new User { Id = 2, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), UserName = "User 2", FamilyId = 2 },
                new User { Id = 3, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), UserName = "User 3", FamilyId = 3 }
                );
        }
    }
}
