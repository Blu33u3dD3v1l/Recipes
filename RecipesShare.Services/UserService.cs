﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
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

            

            await context.SaveChangesAsync();

            
        }

        public async Task<bool> GetUser(string id)
        {
            
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if(user.FirstName != null && user.LastName != null && user.AboutMe != null && user.ImageUrl != null && user.Location != null)
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
