using Back_BookMySport.Models;

namespace Back_BookMySport.Services
{
    public interface ILogin
    {
     Task<User> Login(string username, string password);   
    }
}
