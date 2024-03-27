using Microsoft.AspNetCore.Mvc;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;

namespace RecipesShare.Controllers
{
    public class UserController : Controller
    {


        private readonly IUserService userService;

        public UserController(IUserService _userService)
            => userService = _userService;

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

        [HttpPost]
        public async Task<IActionResult> ProfileFill(string Id, UserModel model)
        {

            await userService.AddUserInformation(Id, model);

            return RedirectToAction("Profile", "User");
        }

    }
}
