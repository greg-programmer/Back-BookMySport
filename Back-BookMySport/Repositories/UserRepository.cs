using AutoMapper;
using Back_BookMySport.Data;
using Back_BookMySport.DTOS;
using Back_BookMySport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Back_BookMySport.Repositories
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserRepository( ApplicationDbContext db, UserManager<User> userManager,IMapper mapper)
        {
            _db = db;
            _userManager = userManager;
            _mapper = mapper;
        }

        //Méthode pour créer un utilisateur/
        public async Task<bool> Create(RegisterRequestDTO registerRequestDTO)
        {
                                
            var userExist = await _userManager.FindByNameAsync(registerRequestDTO.UserName);
            if(userExist != null)
            {
                return false;
            }
            User user = new User();
            user.FirstName = registerRequestDTO.FirstName ;
            user.LastName = registerRequestDTO.LastName ;
            user.UserName = registerRequestDTO.UserName ;
            user.PasswordHash = registerRequestDTO.PasswordHash ;
            user.PhoneNumber = registerRequestDTO.PhoneNumber ;          
            await _userManager.CreateAsync(user, user.PasswordHash);          
             await _db.SaveChangesAsync();    
            return true;            
        }

        public async Task<bool> Delete(string id)
        {
           var user = await _db.Users.FirstOrDefaultAsync( u => u.Id == id);
            if(user != null)
            {
                _db.Users.Remove(user);
                return true;
            }
            return false;
        }

        public async Task<GetUserDTO> GetUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
             GetUserDTO getUserDTO = _mapper.Map<GetUserDTO>(user);
                return getUserDTO;
            }
            return null;
        }

        public async Task<bool> Update(string id, RegisterRequestDTO registerRequestDTO)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
            if(user != null)
            {
                if(user.FirstName != registerRequestDTO.FirstName)
                {
                    user.FirstName = registerRequestDTO.FirstName;
                }
                if(user.LastName != registerRequestDTO.LastName)
                {
                    user.LastName = registerRequestDTO.LastName;
                }
                if(user.UserName != registerRequestDTO.UserName) 
                {
                    var userExist = await _userManager.FindByNameAsync(user.UserName);
                    if (userExist != null)
                    {
                        return false;
                    }
                }
                if(user.PhoneNumber != registerRequestDTO.PhoneNumber) 
                {
                    user.PhoneNumber = registerRequestDTO.PhoneNumber;
                }
                if(user.PasswordHash != registerRequestDTO.PasswordHash)
                {
                    user.PasswordHash = registerRequestDTO.PasswordHash;
                }
                return true;
            }        
      
            if(user != null)
            {
                _db.Users.Add(user);
            }
            return true;
        }
    }
}
