using Microsoft.AspNetCore.Mvc;

namespace RecipesShare.Controllers
{
    public class UserController : Controller
    {


        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProfileFill()
        {
            return View();
        }
    }
}
