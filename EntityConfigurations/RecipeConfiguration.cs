using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.EntityConfigurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder
                .HasKey(r => r.RecipeId);

            builder
                .Property(r => r.RecipeId)
                .IsRequired();

            builder
                .Property(r => r.Name)
                .IsRequired();

            builder
                .Property(r => r.Description)
                .IsRequired(false);

            builder
                .Property(r => r.Instructions)
                .IsRequired();

            builder
                .HasMany(r => r.Ingredients)
                .WithMany(i => i.Recipes);

            builder
              .Property(r => r.Tags)
              .IsRequired(false);

            builder
                .HasMany(r => r.Tags)
                .WithMany(t => t.Recipes);
        }
    }
}
