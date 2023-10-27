using Back_BookMySport.DTOS;
using Back_BookMySport.Models;

namespace Back_BookMySport.Repositories
{
    public interface IUser
    {
        Task<GetUserDTO> GetUser(string id);
       Task<bool> Create(RegisterRequestDTO registerRequestDTO);
        Task<bool> Delete(string id);
        Task<bool> Update(string id, RegisterRequestDTO registerRequestDTO);
    }
}
