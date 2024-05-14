using Microsoft.AspNetCore.Mvc;

namespace RecipesShare.Controllers
{
    public class CuisineController : Controller
    {
        public IActionResult AllCuisine()
        {
            return View();
        }
    }
}
