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
            model.Ingredients = new List<Ingredient>(); // Make sure to initialize the Ingredients list
            return View(model);
            
        }

        public async Task<IActionResult> AddRecipe([FromBody] RecipeModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var thisId = User.GetId();

            await recipeService.AddRecipeWithIngredientsAsync(thisId, model);

            return Ok("Recipe added successfully.");
        }

        //[HttpPost]
        //public async Task<IActionResult> AddRecipe(RecipeModel model)
        //{

        //    var thisId = User.GetId();
        //    try
        //    {
        //        await this.recipeService.AddRecipeAsync(thisId, model);
        //    }
        //    catch (Exception)
        //    {

        //        ModelState.AddModelError(string.Empty, "Unexpected Error");
        //        return View();
        //    }

        //    return RedirectToAction("Index", "Home");
        //}

        [AllowAnonymous]
        public IActionResult RecipeView()
        {
            return View();
        }

    }
}
