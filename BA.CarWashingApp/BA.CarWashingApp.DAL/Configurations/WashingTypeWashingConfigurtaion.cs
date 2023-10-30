using BA.CarWashingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.DAL.Configurations
{
    public class WashingTypeWashingConfigurtaion : IEntityTypeConfiguration<WashingTypeWashing>
    {
        public void Configure(EntityTypeBuilder<WashingTypeWashing> builder)
        {
            builder.HasKey(x => new { x.WashingId, x.WashingTypeId });

            builder
                .HasOne(x => x.Washing)
                .WithMany(x => x.WashingTypeWashings)
                .HasForeignKey(x => x.WashingId);
            builder
                .HasOne(x => x.WashingType)
                .WithMany(x => x.WashingTypeWashings)
                .HasForeignKey(x => x.WashingTypeId);
        }
    }
}
