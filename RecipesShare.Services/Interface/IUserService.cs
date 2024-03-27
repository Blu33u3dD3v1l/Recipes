using RecipesShare.Models.Home;

namespace RecipesShare.Services.Interface
{
    public interface IUserService
    {
        Task AddUserInformation(string Id, UserModel model);
    }
}
