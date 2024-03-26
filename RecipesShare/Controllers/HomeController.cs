using Microsoft.AspNetCore.Mvc;
using RecipesShare.Models;
using RecipesShare.Services.Interface;
using System.Diagnostics;
namespace RecipesShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeService recipeService;

        public HomeController(IRecipeService _recipeService)
            => recipeService = _recipeService;

        public async Task<IActionResult> Index()
        {
            var model = await recipeService.GetAllRecipesAsync();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
