using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Tags = new List<Tag>();
            Ingredients = new List<Ingredient>();
        }
        public Guid RecipeId { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public string Instructions { get; set; }
        public Category Category { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
