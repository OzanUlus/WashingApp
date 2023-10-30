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
    public class WashingStepConfigurtaion : IEntityTypeConfiguration<WashingStep>
    {
        public void Configure(EntityTypeBuilder<WashingStep> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.StepName)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(x => x.StepTime)
                .IsRequired();

            builder
                .HasOne(x => x.WashingType)
                .WithMany(x => x.WashingSteps)
                .HasForeignKey(x => x.WashingTypeId);
        }
    }
}
