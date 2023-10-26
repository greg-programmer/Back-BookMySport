using Back_BookMySport.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      public DbSet<User> Users { get; set; }
      public DbSet<Booking> BookingsDBList { get; set; }
      
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
