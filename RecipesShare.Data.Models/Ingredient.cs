using System.ComponentModel.DataAnnotations;


namespace RecipesShare.Data.Models
{
    public class Ingredient
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }        
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    }
}
