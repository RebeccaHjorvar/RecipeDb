using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.EntityConfigurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder
                .HasKey(i => i.IngredientId);
            builder
                .Property(i => i.IngredientId)
                .IsRequired();
            builder
                .Property(i => i.Name)
                .IsRequired();
            builder
                .Property(i => i.CaloriesPer100Gram)
                .IsRequired(false);
            builder
                .Property(i => i.Amount)
                .IsRequired();

            //--------------------------------
            //Does this require a connection?

            builder
                .Property(i => i.AmountType)
                .IsRequired();
            
            builder
                .Property(i => i.Recipes)
                .IsRequired();
            //--------------------------------

        }
    }
}
