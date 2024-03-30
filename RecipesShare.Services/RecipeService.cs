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

        //public async Task AddRecipeAsync(string id, RecipeModel model, List<int> ingredientIds)
        //{

        //    var recipe = new Recipe()
        //    {
        //        Name = model.Name,
        //        Description = model.Description,
        //        ImageUrl = model.ImageUrl,
        //        CookTime = model.CookTime,
        //        UserId = id,
        //        RecipeIngredients = new List<RecipeIngredient>()

        //    };

        //    foreach (int ingredientId in ingredientIds)
        //    {
        //        var recipeIngredient = new RecipeIngredient
        //        {
        //            IngredientId = ingredientId
        //        };

        //        recipe.RecipeIngredients.Add(recipeIngredient);
        //    }



        //    await context.Recipes.AddAsync(recipe);
        //    await context.SaveChangesAsync();

            
        //}

        public async Task AddRecipeWithIngredientsAsync(string userId, RecipeModel model)
        {
            var recipe = new Recipe
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                CookTime = model.CookTime,
                UserId = userId,
                RecipeIngredients = new List<RecipeIngredient>()
            };

            foreach (var ingredient in model.Ingredients)
            {
                var existingIngredient = await context.Ingredients.FirstOrDefaultAsync(i => i.Name == ingredient.Name);
                if (existingIngredient != null)
                {
                    recipe.RecipeIngredients.Add(new RecipeIngredient { Ingredient = existingIngredient });
                }
                else
                {
                    var newIngredient = new Ingredient { Name = ingredient.Name };
                    recipe.RecipeIngredients.Add(new RecipeIngredient { Ingredient = newIngredient });
                }
            }

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
