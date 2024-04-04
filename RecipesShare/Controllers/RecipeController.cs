using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> AddRecipe()
        {

            RecipeModel m = new RecipeModel();

            var userId = User.GetId();
            var user = await recipeService.GetAppUser(userId);
           
           
           
            if (user?.ImageUrl != null &&
                user.FirstName != null &&
                user.LastName != null &&
                user.Sex != null &&
                user.Location != null &&
                user.Country != null &&
                user.PhoneNumber != null)
            {
              
               m = new RecipeModel();
               return View(m);

            }
            else
            {
                return RedirectToAction("ProfileFill", "User");
            }
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
            catch (Exception)
            {
                return RedirectToAction("ProfileFill","User");
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

        public async Task<IActionResult> MyRecipes()
        {

            var myId = User.GetId();
            var model = await recipeService.GetMyRecipesAsync(myId);
            return View(model);

        }
    }
}
