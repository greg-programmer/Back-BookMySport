using Back_BookMySport.DTOS;
using Back_BookMySport.Models;

namespace Back_BookMySport.Repositories
{
    public interface IUser
    {
       Task<bool> Create(RegisterRequestDTO registerRequestDTO);
    }
}
