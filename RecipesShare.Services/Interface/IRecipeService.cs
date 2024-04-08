using RecipesShare.Data.Models;
using RecipesShare.Models.Home;

namespace RecipesShare.Services.Interface
{
    public interface IRecipeService
    {

        Task<IEnumerable<RecipeModel>> GetAllRecipesAsync();
        Task AddRecipeAsync(string id, RecipeModel model);
        Task<Recipe> GetRecipeWithIngredientsAsync(int id);
        Task<IEnumerable<RecipeModel>> GetMyRecipesAsync(string id);
        Task<Data.Models.ApplicationUser> GetAppUser(string id);
        Task<RecipeModel> GetEditRecipe(int id);
        Task PostEditRecipe(int id, RecipeModel model);

    }
}
