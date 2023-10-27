using Back_BookMySport.Data;
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

        public UserRepository(BCryptPasswordHasher<User> hasher, ApplicationDbContext db, UserManager<User> userManager)
        {
            _Hasher = hasher;
            _db = db;
            _userManager = userManager;
        }

        //Méthode pour créer un utilisateur/
        public async Task<bool> Create(User user)
        {
            user.UserName = user.UserName.ToLower();
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
