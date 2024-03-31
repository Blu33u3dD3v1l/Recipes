using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesShare.Data.Models
{
    public class Ingredient
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }        
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    }
}
