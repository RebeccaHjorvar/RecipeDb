using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Models
{
    public class Tag
    {
        public Tag()
        {
            Recipes = new List<Recipe>();
        }
        public Guid TagId { get; set; }
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
