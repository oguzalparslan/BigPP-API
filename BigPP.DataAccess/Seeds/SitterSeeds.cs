using BigPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.Seeds
{
    public class SitterSeeds : IEntityTypeConfiguration<Sitter>
    {
        public void Configure(EntityTypeBuilder<Sitter> builder)
        {
            builder.HasData(
                new Sitter { Id = 1, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), SitterName = "Sitter 1", SitterPhone = "12312312312" },
                new Sitter { Id = 2, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), SitterName = "Sitter 2", SitterPhone = "12312312312" },
                new Sitter { Id = 3, CreatedDate = DateTime.Now, Identity = Guid.NewGuid(), SitterName = "Sitter 3", SitterPhone = "12312312312" }
                );
        }
    }
}
