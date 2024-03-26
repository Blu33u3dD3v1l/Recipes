using RecipesShare.Models.Home;

namespace RecipesShare.Services.Interface
{
    public interface IRecipeService
    {

        Task<IEnumerable<RecipeModel>> GetAllRecipesAsync();
    }
}
