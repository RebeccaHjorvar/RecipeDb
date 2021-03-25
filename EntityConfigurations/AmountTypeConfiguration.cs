using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;

namespace Recipes.EntityConfigurations
{
    public class AmountTypeConfiguration : IEntityTypeConfiguration<AmountType>
    {
        public void Configure(EntityTypeBuilder<AmountType> builder)
        {   
            // Primary Key
            builder
                .HasKey(at => at.AmountTypeId);
            builder
                .Property(at => at.AmountTypeId)
                .IsRequired();

            // Name
            builder
                .Property(at => at.Name)
                .IsRequired();

            // Many ingredients have one amount type
            builder
                .HasMany(at => at.Ingredients)
                .WithOne(i => i.AmountType);

            /* THIS DOES NOT WORK ?? Should'nt this be many to many?
            builder
                .HasMany(at => at.Ingredients)
                .WithMany(i => i.AmountType);
            */
        }
    }
}
