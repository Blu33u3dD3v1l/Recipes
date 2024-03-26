using Microsoft.AspNetCore.Mvc;
using RecipesShare.Services.Interface;

namespace RecipesShare.Controllers
{
    public class RecipeController : Controller
    {
         private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService _recipeService)
            => recipeService = _recipeService;

        public async Task<IActionResult> All()
        {
            var model = await recipeService.GetAllRecipesAsync();

            return View(model);
        }
    }
}
