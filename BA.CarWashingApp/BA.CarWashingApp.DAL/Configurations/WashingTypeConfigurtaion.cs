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
    public class WashingTypeConfigurtaion : IEntityTypeConfiguration<WashingType>
    {
        public void Configure(EntityTypeBuilder<WashingType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(wt => wt.TypeName)
            .IsRequired()
            .HasMaxLength(50); 

            builder.Property(wt => wt.TypeTime)
                .IsRequired();

            builder.Property(wt => wt.TypePrice)
                .HasPrecision(5,2)
                .IsRequired();

            builder.Property(wt => wt.MaterialFactor)
                .HasPrecision(4,2)
                .IsRequired();
        }
    }
}
