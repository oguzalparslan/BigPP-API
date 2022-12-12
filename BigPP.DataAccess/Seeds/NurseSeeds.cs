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
    public class NurseSeeds : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.HasData(
                new Nurse { Id=1,Identity=Guid.NewGuid(),CreatedDate=DateTime.Now,NurseName="Nurse",NursePhone="123456"},
                new Nurse { Id=2,Identity=Guid.NewGuid(),CreatedDate=DateTime.Now,NurseName="Nurse2",NursePhone="123456"},
                new Nurse { Id=3,Identity=Guid.NewGuid(),CreatedDate=DateTime.Now,NurseName="Nurse3",NursePhone="123456"}
                );
        }
    }
}
