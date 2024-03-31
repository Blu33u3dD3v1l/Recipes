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

        public async Task AddRecipeAsync(string id, RecipeModel model)
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
                    CookTime = model.CookTime,
                    Instructions = model.Instructions,
                    Author = model.Author,
                    UserId = id,
                    
                    
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
            catch (Exception)
            {
               
                throw new Exception();
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

        public async Task<Recipe> GetRecipeWithIngredientsAsync(int id)
        {

            var recipe = await context.Recipes
            .Include(x => x.User)
            .Include(r => r.RecipeIngredients)
            .ThenInclude(ri => ri.Ingredient)  
            
            .FirstOrDefaultAsync(r => r.Id == id);

            if(recipe == null)
            {
                throw new Exception();
            }

            return recipe;
        }
    }
}
