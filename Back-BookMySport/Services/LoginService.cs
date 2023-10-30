using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Back_BookMySport.Services
{
    public class LoginService : ILogin
    {
        private readonly UserManager<User> _userManager;       

        public LoginService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<User> Login(string username, string password)
        {
            var userExist = await _userManager.FindByNameAsync(username);
            var passwordExist = await _userManager.CheckPasswordAsync(userExist, password);
            if (userExist != null && passwordExist)
            {
                return userExist;
            }
            return null;            
        }
    }
}
