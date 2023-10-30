using Back_BookMySport.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      public DbSet<User> Users { get; set; }
      public DbSet<Booking> Bookings { get; set; }
      public DbSet<Session> Sessions { get; set; }

      public DbSet<Gym> Gyms { get; set; }

      public DbSet<SportCategory> SportCategories { get; set; }
      // public DbSet<Gym> GymDBList { get; set; }
      
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var sportCategory = new List<SportCategory>()
            {
                new SportCategory(){Id = 1,Name = "Fitness"},
                new SportCategory(){Id = 2,Name = "Basketball"},
                new SportCategory(){Id = 3,Name = "Football"},
                new SportCategory(){Id = 4,Name = "Boxe"},
                new SportCategory(){Id = 5,Name = "Volley"}
            };
            builder.Entity<SportCategory>().HasData(sportCategory);

            var session = new Session()
            {
                Id = 1,
                Name = "Séance 1",
                Description = "Séance de fitness",
                MaxBooking = 3,
                ImagePath = "",
                Bookings = new List<Booking>(),
                StartTime = new DateTime(2023, 10, 27, 16, 0, 0),
                FinishTime = new DateTime(2023, 10, 27, 17, 0, 0),
                SportCategoryId = 1,
                GymId = 1
            };

            builder.Entity<Session>().HasData(session);

            var gym = new Gym()
            {
                Id = 1,
                Name = "Fitness Park",
                Address = "1 rue Lille, 59000 Lille",
                Phone = "0608090909"


            };

            builder.Entity<Gym>().HasData(gym);
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "1",
                    LastName = "Schoemaecker",
                    FirstName = "Grégory",
                    UserName = "test@gmail.com",
                    PasswordHash = "12345azertyA/",
                    PhoneNumber = "0606060606",
                    Phone = "0606060606"
                });
            
        }
    }
}
