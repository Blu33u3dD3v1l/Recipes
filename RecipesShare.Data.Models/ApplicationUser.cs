using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static RecipesShare.Common.Constants.ValidataionConstants;


namespace RecipesShare.Data.Models
{
    public class ApplicationUser : IdentityUser
    {

        [MaxLength(AppUserValidations.UserFirstNameMaxValidation)]
        public string? FirstName { get; set; }

        [MaxLength(AppUserValidations.UserLastNameMaxValidation)]
        public string? LastName { get; set; }

        [Url]
        public string? ImageUrl { get; set; }
        public string? Location { get; set; }
        public string? AboutMe { get; set; }
        public string? Country { get; set; }
        public string? Sex { get; set; }

        [Url]
        public string? SocialMediaProfileUrl { get; set; }
        public string? AdditionalInfo { get; set; }     
        public List<UserRecipe> UserRecipes { get; set; } = new List<UserRecipe>();
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();




    }
}
