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
    public class MaterialWashingRecipeConfigurtaion : IEntityTypeConfiguration<MaterialWashingRecipe>
    {
        public void Configure(EntityTypeBuilder<MaterialWashingRecipe> builder)
        {
            builder.HasKey(x => new { x.MaterialId, x.WashingRecipeId });

            builder
                .HasOne(x => x.Material)
                .WithMany(x => x.MaterialWashingRecipes)
                .HasForeignKey(x => x.MaterialId);
            builder
                .HasOne(x => x.WashingRecipe)
                .WithMany(x => x.MaterialWashingRecipes)
                .HasForeignKey(x => x.WashingRecipeId);
        }
    }
}
