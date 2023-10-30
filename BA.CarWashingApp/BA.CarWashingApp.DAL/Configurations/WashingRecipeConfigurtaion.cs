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
    public class WashingRecipeConfigurtaion : IEntityTypeConfiguration<WashingRecipe>
    {
        public void Configure(EntityTypeBuilder<WashingRecipe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(wm => wm.MaterialName)
            .IsRequired()
            .HasMaxLength(50); 

            builder.Property(wm => wm.Amount)
                .HasPrecision(6,2)
                .IsRequired();

            builder.Property(wm => wm.PriceFactor)
                .HasPrecision(4,2)
                .IsRequired();
        }
    }
}
