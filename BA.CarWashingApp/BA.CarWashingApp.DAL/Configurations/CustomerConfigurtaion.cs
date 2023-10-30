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
    public class CustomerConfigurtaion : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(x => x.SurName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(x => x.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(x => x.PhoneNumber)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
