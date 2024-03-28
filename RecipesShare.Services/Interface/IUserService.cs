using RecipesShare.Data.Models;
using RecipesShare.Models.Home;

namespace RecipesShare.Services.Interface
{
    public interface IUserService
    {
        Task AddUserInformation(string id, Models.Home.ApplicationUser model);
        Task<bool> GetUser(string id);
        Task<Data.Models.ApplicationUser> RealUserTake(string id);

    }
}
