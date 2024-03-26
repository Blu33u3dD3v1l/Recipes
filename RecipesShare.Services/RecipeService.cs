using Microsoft.EntityFrameworkCore;
using RecipesShare.Data;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;

namespace RecipesShare.Services
{
    public class RecipeService : IRecipeService
    {

        private readonly ApplicationDbContext context;

        public RecipeService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<RecipeModel>> GetAllRecipesAsync()
        {
            var recipes = await context.Recipes
               .Select(x => new RecipeModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Description = x.Description,
                   CookTime = x.CookTime,


               }).ToListAsync();

            return recipes;
        }
    }
}
