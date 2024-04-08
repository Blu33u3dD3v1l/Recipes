using Microsoft.AspNetCore.Mvc;
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
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if(user?.ImageUrl != null && user.FirstName != null && user.LastName != null && user.Sex != null && user.Location != null && user.Country != null && user.PhoneNumber != null)
            {
                var ingredient = new Ingredient
                {
                    Name = model.Ingredients
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

                await context.SaveChangesAsync();

                context.Recipes.Add(recipe);

                await context.SaveChangesAsync();

                var recipeIngredient = new RecipeIngredient
                {
                    IngredientId = ingredient.Id,
                    RecipeId = recipe.Id
                };


                context.RecipeIngredients.Add(recipeIngredient);

                var userRecipe = new UserRecipe
                {
                    UserId = id,
                    RecipeId = recipe.Id
                };

                context.UserRecipes.Add(userRecipe);

                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Fill Identity first!");
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
            .Include(x => x.UserRecipes)
            .Include(r => r.RecipeIngredients)
            .ThenInclude(ri => ri.Ingredient)
            .FirstOrDefaultAsync(r => r.Id == id);

            if (recipe == null)
            {
                throw new Exception();
            }

            return recipe;
        }


        public async Task<IEnumerable<RecipeModel>> GetMyRecipesAsync(string id)
        {
            var user = await context.Users
                .Where(u => u.Id == id)
                .Include(u => u.UserRecipes)              
                  .ThenInclude(ur => ur.Recipe)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }
            
            return user!.UserRecipes!
                .Where(m => m.Recipe != null) 
                .Select(m => new RecipeModel()
                {
                    Id = m.Recipe!.Id,
                    Name = m.Recipe.Name,
                    ImageUrl = m.Recipe.ImageUrl,
                    Author = m.Recipe.Author,
                    CookTime = m.Recipe.CookTime,
                    Description = m.Recipe.Description,
                    UserId = id,
                    Instructions = m.Recipe.Instructions,
                });
        }

        public async Task<Data.Models.ApplicationUser> GetAppUser(string id)
        {
            var thisUser = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (thisUser == null)
            {
                throw new NullReferenceException();
            }

            return thisUser;
        }

     
        public async Task<RecipeModel> GetEditRecipe(int id)
        {

            var currenrRecupe = await context.Recipes
                .Include(x => x.RecipeIngredients)
                 .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(currenrRecupe == null)
            {
                throw new Exception();
            }

            var ingredient = currenrRecupe.RecipeIngredients.FirstOrDefault()?.Ingredient.Name;

   
            return new RecipeModel
            {
              Name = currenrRecupe.Name,
              Author = currenrRecupe.Author,
              CookTime = currenrRecupe.CookTime,
              Description = currenrRecupe.Description,
              Id = currenrRecupe.Id,
              ImageUrl= currenrRecupe.ImageUrl,
              Instructions = currenrRecupe.Instructions,
              Ingredients = ingredient,
            };

        }

        public async Task PostEditRecipe(int id, RecipeModel model)
        {
            var recipe = await context.Recipes
                  .Include(x => x.RecipeIngredients)
                   .ThenInclude(ri => ri.Ingredient)
                  
                  .FirstOrDefaultAsync(x => x.Id == id);

            if (recipe == null)
            {
                throw new NullReferenceException();
            }

            var ingredient = recipe?.RecipeIngredients?.FirstOrDefault()?.Ingredient;
           

            recipe!.Author = model.Author;
            recipe.Instructions = model.Instructions;
            recipe.CookTime = model.CookTime;
            recipe.Description = model.Description;
            recipe.Id = id;
            recipe.ImageUrl = model.ImageUrl;
            ingredient!.Name = model.Ingredients;
            
            await context.SaveChangesAsync();
            
        }
    }
}


