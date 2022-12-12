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
    public class NotConnectionUserSeeds : IEntityTypeConfiguration<NotConnectionUser>
    {
        public void Configure(EntityTypeBuilder<NotConnectionUser> builder)
        {
            builder.HasData(
                new NotConnectionUser { Id = 1, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, UserId = 1 },
                new NotConnectionUser { Id = 2, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, UserId = 2 },
                new NotConnectionUser { Id = 3, Identity = Guid.NewGuid(), CreatedDate = DateTime.Now, UserId = 3 }
            );
        }
    }
}
