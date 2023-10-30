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
    public class VehicleConfigurtaion : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(v => v.LicensePlate)
            .IsRequired()
            .HasMaxLength(20); 

            builder.Property(v => v.Brand)
                .IsRequired()
                .HasMaxLength(50); 

            builder.Property(v => v.Model)
                .HasMaxLength(50);

            builder.Property(v => v.Color)
                .HasMaxLength(30);

            builder
                .HasOne(x => x.VehicleType)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(x => x.VehicleTypeId);
            builder
                .HasOne(x => x.DirtStatus)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(x => x.DirtStatusId);
            builder
                .HasOne(x => x.Customer)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}
