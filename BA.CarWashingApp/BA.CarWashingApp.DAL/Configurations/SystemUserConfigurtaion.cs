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
    public class SystemUserConfigurtaion : IEntityTypeConfiguration<SystemUser>
    {
        public void Configure(EntityTypeBuilder<SystemUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasAlternateKey(x => x.UserName);

            builder
                .Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(20);

        }
    }
}
