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
    public class VisitorSeeds : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            builder.HasData(
                new Visitor { Id = 1, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), VisitorName = "Visitor 1", VisitorPhone = "12312312332", UserId = 1 },
                new Visitor { Id = 2, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), VisitorName = "Visitor 2", VisitorPhone = "12312312332", UserId = 2 },
                new Visitor { Id = 3, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), VisitorName = "Visitor 3", VisitorPhone = "12312312332", UserId = 3 }
                );
        }
    }
}
