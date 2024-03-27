using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;

namespace RecipesShare.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
         private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService _recipeService)
            => recipeService = _recipeService;

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(RecipeModel model)
        {
            try
            {
                await this.recipeService.AddRecipeAsync(model);
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
