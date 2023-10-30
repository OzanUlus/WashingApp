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
    public class DirtStatusConfigurtaion : IEntityTypeConfiguration<DirtStatus>
    {
        public void Configure(EntityTypeBuilder<DirtStatus> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(s => s.StatusName)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(s => s.TimeFactor)
                .HasPrecision(4,2)
                .IsRequired();

            builder.Property(s => s.PriceFactor)
                .HasPrecision(4, 2)
                .IsRequired();

            builder.Property(s => s.MaterialFactor)
                .HasPrecision(4, 2)
                .IsRequired();
        }
    }
}
