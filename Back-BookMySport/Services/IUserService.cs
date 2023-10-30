using Back_BookMySport.Models;

namespace Back_BookMySport.Services
{
    public interface IUserService
    {
     Task<User> Login(string username, string password);       
    }
}
