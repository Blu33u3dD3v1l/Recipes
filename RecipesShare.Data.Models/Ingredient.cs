using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesShare.Data.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            RecipeIngredients = new List<RecipeIngredient>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
