using RecipesShare.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace RecipesShare.Models.Home
{
    public class RecipeModel
    {
        public RecipeModel()
        {
            Ingredients = new List<Ingredient>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [MaxLength(364)]
        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int CookTime { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
        
    }
}
