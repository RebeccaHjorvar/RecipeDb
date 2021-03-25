using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Models
{

    public class Ingredient
    {
        public Ingredient()
        {
            Recipes = new List<Recipe>();
        }
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int? CaloriesPer100Gram { get; set; } // nullable
        public double Amount { get; set; }
        public AmountType AmountType { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

    }
}
