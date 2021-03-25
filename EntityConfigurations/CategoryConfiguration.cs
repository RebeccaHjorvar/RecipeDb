using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>

    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Primary key
           builder
                .HasKey(c => c.Name);

            builder
                .Property(c => c.Name)
                .IsRequired();

            // Description
            builder
                .Property(c => c.Description)
                .IsRequired(false);

            // Many recipes to one category
            builder
                .HasMany(c => c.Recipes)
                .WithOne(r => r.Category);

        }
    }
}
