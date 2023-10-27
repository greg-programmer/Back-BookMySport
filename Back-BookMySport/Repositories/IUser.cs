using Back_BookMySport.Models;

namespace Back_BookMySport.Repositories
{
    public interface IUser
    {
       Task<bool> Create(User user);
    }
}
