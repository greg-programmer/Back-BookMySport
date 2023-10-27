using AutoMapper;
using Back_BookMySport.Data;
using Back_BookMySport.DTOS;
using Back_BookMySport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ScottBrady91.AspNetCore.Identity;

namespace Back_BookMySport.Repositories
{
    public class UserRepository : IUser
    {
        private readonly  BCryptPasswordHasher<User> _Hasher;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(BCryptPasswordHasher<User> hasher, ApplicationDbContext db, UserManager<User> userManager,IMapper mapper)
        {
            _Hasher = hasher;
            _db = db;
            _userManager = userManager;
            _mapper = mapper;
        }

        //Méthode pour créer un utilisateur/
        public async Task<bool> Create(RegisterRequestDTO registerRequestDTO)
        {
            User user = new User();  
            user.FirstName = registerRequestDTO.FirstName;
            user.LastName = registerRequestDTO.LastName;
            user.UserName = registerRequestDTO.Email;
            user.PhoneNumber = registerRequestDTO.PhoneNumber;
            user.PasswordHash = registerRequestDTO.password;
            RegisterRequestDTO registerDTO = _mapper.Map<RegisterRequestDTO>(user);

            var userExist = await _userManager.FindByNameAsync(user.UserName);
            if(userExist != null)
            {
                return false;
            }
             await _userManager.CreateAsync(user, user.PasswordHash);           
             await _db.SaveChangesAsync();    
            return true;            
        }
    }
}
