using System.ComponentModel.DataAnnotations;

namespace RecipesShare.Data.Models
{
    public class Recipe
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int CookTime { get; set; }

        public string? Author { get; set; }
        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        public string? Instructions { get; set; }
        public DateOnly Created { get; set; }
        public int Edited { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; } = new 
        List<RecipeIngredient>();
        public List<UserRecipe> UserRecipes { get; set; } = new List<UserRecipe>();

    }
}
