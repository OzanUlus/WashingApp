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
    public class EmployeeConfigurtaion : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e => e.SurName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShiftStartTime)
                .IsRequired();

            builder.Property(e => e.ShiftEndTime)
                .IsRequired();

            builder.Property(e => e.Position)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Salary)
                .HasPrecision(7,2)
                .IsRequired();

            builder.Property(e => e.TotalLeave)
                .IsRequired();

            builder.Property(e => e.UsedLeave)
                .IsRequired();

            builder.Property(e => e.RemainingLeave)
                .IsRequired();

            builder
                .HasOne(x => x.SystemUser)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.SystemUserId);
        }
    }
}
