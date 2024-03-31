using Microsoft.EntityFrameworkCore;
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

            try
            {
                var ingredient = new Ingredient
                {
                    Name = model.Ingredient
                };

                context.Ingredients.Add(ingredient);

                var recipe = new Recipe
                {
                    Name = model.Name,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    CookTime = model.CookTime
                };

                context.Recipes.Add(recipe);

                await context.SaveChangesAsync();

                var recipeIngredient = new RecipeIngredient
                {
                    IngredientId = ingredient.Id,
                    RecipeId = recipe.Id
                };

                context.RecipeIngredients.Add(recipeIngredient);

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log the error, provide user feedback)
                // For debugging purposes, you can inspect the inner exception for more details
                throw ex;
            }
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
