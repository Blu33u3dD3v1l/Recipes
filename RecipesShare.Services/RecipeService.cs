using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using RecipesShare.Data;
using RecipesShare.Data.Models;
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

        public async Task AddRecipeAsync(RecipeModel model)
        {
            var recipe = new Recipe()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                CookTime = model.CookTime,

            };

            await context.Recipes.AddAsync(recipe);
            await context.SaveChangesAsync();
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
