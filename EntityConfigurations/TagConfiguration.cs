using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.EntityConfigurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {   
            // Primary key
            builder
                .HasKey(t => t.TagId);
            builder
                .Property(t => t.TagId)
                .IsRequired();

            // Name
            builder
                .Property(t => t.Name)
                .IsRequired();

            // Many recipes with many tags
            builder
                .HasMany(t => t.Recipes)
                .WithMany(r => r.Tags);
        }
    }
}
