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
    public class WashingConfigurtaion : IEntityTypeConfiguration<Washing>
    {
        public void Configure(EntityTypeBuilder<Washing> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(w => w.RemainingTime)
            .IsRequired();

            builder.Property(w => w.TotalPrice)
                .HasPrecision(6,2)
                .IsRequired();

            builder
                .HasOne(x => x.Employee)
                .WithOne(x => x.Washing)
                .HasForeignKey<Employee>(x => x.WashingId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
               .HasOne(x => x.Vehicle)
               .WithOne(x => x.Washing)
               .HasForeignKey<Vehicle>(x => x.WashingId)
               .OnDelete(DeleteBehavior.NoAction);
            builder
               .HasOne(x => x.WashingRecipe)
               .WithMany(x => x.Washings)
               .HasForeignKey(x => x.WashingRecipeId);

        }
    }
}
