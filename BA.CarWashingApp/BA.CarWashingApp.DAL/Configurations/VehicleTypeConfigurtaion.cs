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
    public class VehicleTypeConfigurtaion : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(wt => wt.TypeName)
           .IsRequired()
           .HasMaxLength(30); 

            builder.Property(wt => wt.TimeFactor)
                .HasPrecision(4,2)
                .IsRequired();

            builder.Property(wt => wt.PriceFactor)
                .HasPrecision(4, 2)
                .IsRequired();

            builder.Property(wt => wt.MaterialFactor)
                .HasPrecision(4, 2)
                .IsRequired();
        }
    }
}
