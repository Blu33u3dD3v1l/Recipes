using Microsoft.EntityFrameworkCore;
using RecipesShare.Data;
using RecipesShare.Data.Models;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;

namespace RecipesShare.Services
{
    public class UserService : IUserService
    {

        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task AddUserInformation(string Id, UserModel model)
        {


            var existingUser = context.ApplicationUser.FirstOrDefaultAsync(x => x.Id == Id);
            if (existingUser == null)
            {
                throw new NullReferenceException();
            }


            var a = context.ApplicationUser.FindAsync(existingUser);

            a.Result!.ImageUrl = model.ImageUrl;
            a.Result.FirstName = model.FirstName;
            a.Result.LastName = model.LastName;
            a.Result.AboutMe = model.AboutMe;

            await context.SaveChangesAsync();
        }
    }
}
