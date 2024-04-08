using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using RecipesShare.Data;
using RecipesShare.Data.Models;
using RecipesShare.Models.Home;
using RecipesShare.Services.Interface;
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
            existingUser.SocialMediaProfileUrl = model.SocialMediaProfileUrl;
            existingUser.AdditionalInfo = model.AdditionalInfo;
            existingUser.PhoneNumber = model.PhoneNumber;
          
            
            
            await context.SaveChangesAsync();

            
        }

        public async Task<string> ChangeImageAsync(string imageUrl, IFormFile imageFilePath, string id)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                throw new ArgumentException("User not found.");
            }

            string newImageUrl;


            if (!string.IsNullOrEmpty(imageUrl) && imageFilePath == null)
            {
                
                user.ImageUrl = imageUrl;
                newImageUrl = imageUrl;
            }
            else if (imageFilePath != null && string.IsNullOrEmpty(imageUrl))
            {

                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFilePath.FileName);
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFilePath.CopyToAsync(fileStream);
                }

                user.ImageUrl = "/images/" + uniqueFileName;
                newImageUrl = user.ImageUrl;
            }
            else
            {
                throw new ArgumentException("ImageUrl or ImageFilePath must be provided.");
            }

           
            context.Users.Update(user);
            await context.SaveChangesAsync();

            return newImageUrl;
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
            existingUser.PhoneNumber = model.PhoneNumber;
            existingUser.SocialMediaProfileUrl = model.SocialMediaProfileUrl;
            existingUser.AdditionalInfo = model.AdditionalInfo;




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
                AdditionalInfo = currentUser.AdditionalInfo,
                SocialMediaProfileUrl = currentUser.SocialMediaProfileUrl,
                PhoneNumber = currentUser.PhoneNumber,
                
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

        public async Task<Data.Models.ApplicationUser> GetUserImageForChangeAsync(string id)
        {
            var thisUser = await context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if(thisUser == null)
            {
                throw new InvalidOperationException();
            }

            
            return thisUser;
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
