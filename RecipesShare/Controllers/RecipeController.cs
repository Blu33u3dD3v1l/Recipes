using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesShare.Data.Models;
using RecipesShare.Models.Home;
using RecipesShare.Services;
using RecipesShare.Services.Interface;
using RecipesShare.WebExtensions;

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
            var model = new RecipeModel();         
            return View(model);
            
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(RecipeModel model)
        {

            var thisId = User.GetId();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await recipeService.AddRecipeAsync(thisId, model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [AllowAnonymous]
        public async Task<IActionResult> RecipeDetails(int id)
        {
            var recipe = await recipeService.GetRecipeWithIngredientsAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

    }
}
