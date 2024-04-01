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

        public async Task<IActionResult> ChangeInfo()
        {
                var currId = User.GetId();
                var view = await userService.GetEditUserAsync(currId);

                return View(view);
            
        }

        [HttpPost]
        public async Task<IActionResult> ChangeInfo(ApplicationUser model)
        {
            var id = User.GetId();

            await userService.ChangeUserInformation(id, model);

            return RedirectToAction("Profile", "User");
        }

        public async Task<IActionResult> ChangePicture()
        {
            var currId = User.GetId();
            var result = await userService.GetUserImageForChangeAsync(currId);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePicture(string imageUrl, IFormFile imageFile)
        {

            var userId = User.GetId();
            try
            {
                if (string.IsNullOrEmpty(userId))
                {
                    return BadRequest("User ID is required.");
                }

                if (string.IsNullOrEmpty(imageUrl) && imageFile == null)
                {
                    return BadRequest("Either imageUrl or imageFile must be provided.");
                }

                string newImageUrl = await userService.ChangeImageAsync(imageUrl, imageFile, userId);
                return RedirectToAction("Profile", "User");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }
}
