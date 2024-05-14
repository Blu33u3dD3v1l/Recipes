using Microsoft.AspNetCore.Mvc;
using RecipesShare.Cuisine.Data.Data;

namespace RecipesShare.Controllers
{
    public class CuisineController : Controller
    {
        public IActionResult AllCuisine()
        {
            var cuisineData = new AllCuisineData();
            return View(cuisineData);
        }
    }
}
