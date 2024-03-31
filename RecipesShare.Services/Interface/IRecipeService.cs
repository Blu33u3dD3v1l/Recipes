using RecipesShare.Data.Models;
using RecipesShare.Models.Home;

namespace RecipesShare.Services.Interface
{
    public interface IRecipeService
    {

        Task<IEnumerable<RecipeModel>> GetAllRecipesAsync();
        Task AddRecipeAsync(string id, RecipeModel model);
        Task<Recipe> GetRecipeWithIngredientsAsync(int id);


    }
}
