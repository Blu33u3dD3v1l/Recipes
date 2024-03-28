using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;
using RecipesShare.WebExtensions;


namespace RecipesShare.Controllers
{
    [Authorize]
    public class UserController : Controller
    {


        private readonly IUserService userService;

        public UserController(IUserService _userService)
            => userService = _userService;

       
        public async Task<IActionResult> Profile()
        {
            var currentId = User.GetId();
            var currentUser = await userService.GetUser(currentId);

            if(currentUser == true)
            {
                try
                {
                    var b = await userService.RealUserTake(currentId);
                    return View(b);
                }
                catch (Exception)
                {

                    return RedirectToAction("Index", "Home");
                }                          
               
            }
            else
            {
                return RedirectToAction("ProfileFill", "User");
            }
        }

        [HttpGet]
        public IActionResult ProfileFill()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProfileFill(ApplicationUser model)
        {

            var id = User.GetId();

            await userService.AddUserInformation(id, model);

            return RedirectToAction("Profile", "User");
        }

    }
}
