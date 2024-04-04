using Microsoft.AspNetCore.Identity;

namespace RecipesShare.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Location { get; set; }
        public string? AboutMe { get; set; }
        public string? Country { get; set; }
        public string? Sex { get; set; }       
        public string? SocialMediaProfileUrl { get; set; }
        public string? AdditionalInfo { get; set; }     
        public List<UserRecipe> UserRecipes { get; set; } = new List<UserRecipe>();
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();




    }
}
