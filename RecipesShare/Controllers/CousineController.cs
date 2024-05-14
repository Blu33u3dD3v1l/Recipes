using Microsoft.AspNetCore.Mvc;

namespace RecipesShare.Controllers
{
    public class CousineController : Controller
    {
        public IActionResult AllCousine()
        {
            return View();
        }
    }
}
