using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RecipesShare.Data.Models
{
    public class Recipe
    {

        public Recipe()
        {
            RecipeIngredients = new List<RecipeIngredient>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int CookTime { get; set; }
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; }


    }
}
