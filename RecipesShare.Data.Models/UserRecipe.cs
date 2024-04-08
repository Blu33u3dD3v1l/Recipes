namespace RecipesShare.Data.Models
{
    public class UserRecipe
    {
       
        public string UserId { get; set; } = null!;      
        public ApplicationUser User { get; set; } = null!;       
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;
    }
}
