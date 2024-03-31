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
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
        



    }
}
