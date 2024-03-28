using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RecipesShare.Data;
using RecipesShare.Data.Models;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RecipesShare.Services
{
    public class UserService : IUserService
    {

        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task AddUserInformation(string id, Models.Home.ApplicationUser model)
        {


            var existingUser = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (existingUser == null)
            {
                throw new NullReferenceException();
            }
         

            existingUser.ImageUrl = model.ImageUrl;
            existingUser.FirstName = model.FirstName;
            existingUser.LastName = model.LastName;
            existingUser.AboutMe = model.AboutMe;
            existingUser.Location = model.Location;
            existingUser.Sex = model.Sex;
            existingUser.Country = model.Country;
           
            

            

            await context.SaveChangesAsync();

            
        }

        public async Task ChangeUserInformation(string id, Models.Home.ApplicationUser model)
        {
            var existingUser = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (existingUser == null)
            {
                throw new NullReferenceException();
            }


            existingUser.ImageUrl = model.ImageUrl;
            existingUser.FirstName = model.FirstName;
            existingUser.LastName = model.LastName;
            existingUser.AboutMe = model.AboutMe;
            existingUser.Location = model.Location;
            existingUser.Sex = model.Sex;
            existingUser.Country = model.Country;





            await context.SaveChangesAsync();
        }

        public async Task<Data.Models.ApplicationUser> GetEditUserAsync(string id)
        {
            var currentUser = await context.Users              
                .FirstOrDefaultAsync(x => x.Id == id);

            if (currentUser == null)
            {
                throw new ArgumentNullException();
            }

            return new Data.Models.ApplicationUser
            {
                Id = currentUser.Id,
                FirstName = currentUser.FirstName,
                LastName = currentUser.LastName,
                AboutMe = currentUser.AboutMe,
                Country = currentUser.Country,
                ImageUrl = currentUser.ImageUrl,
                Location = currentUser.Location,
                Sex = currentUser.Sex,
            };
        }

        public async Task<bool> GetUser(string id)
        {
            
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if(user.FirstName != null && user.LastName != null && user.AboutMe != null && user.ImageUrl != null && user.Location != null && user.Sex != null && user.Country != null)
            {
                return true;
            }
            else
            {
                return false;
            }     
            
        }

        public async Task<Data.Models.ApplicationUser> RealUserTake(string id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);   
            if(user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Can find this user!");
            }
           
            
        }
    }
}
