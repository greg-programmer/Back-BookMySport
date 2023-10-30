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
                new SportCategory() { Id = 1, Name = "Fitness",Sessions = new List<Session>()},
                new SportCategory() { Id = 2, Name = "Basketball",Sessions = new List<Session>() },
                new SportCategory() { Id = 3, Name = "Football",Sessions = new List<Session>() },
                new SportCategory() { Id = 4, Name = "Boxe",Sessions = new List<Session>() },
                new SportCategory() { Id = 5, Name = "Volley",Sessions = new List<Session>() }
            };
            builder.Entity<SportCategory>().HasData(sportCategory);

            // var session = new Session()
            // {
            //     Id = 1,
            //     Name = "Séance 1",
            //     Description = "Séance de fitness",
            //     MaxBooking = 3,
            //     ImagePath = "",
            //     Bookings = new List<Booking>(),
            //     StartTime = new DateTime(2023,10,27,16,0,0),
            //     FinishTime = new DateTime(2023,10,27,17,0,0),
            //     SportCategoryId = 1,
            //     GymId = 1
            // };
            // var session2 = new Session()
            // {
            //     Id = 2,
            //     Name = "Séance 1",
            //     Description = "Séance de fitness",
            //     MaxBooking = 3,
            //     ImagePath = "",
            //     Bookings = new List<Booking>(),
            //     StartTime = new DateTime(2023,10,27,17,0,0),
            //     FinishTime = new DateTime(2023,10,27,18,0,0),
            //     SportCategoryId = 1,
            //     GymId = 1
            // };
            var sessionId = 1;
            var gymSession = new List<Session>();
            
            for (int j = 0; j < 13; j++)
            {
                var a = new Session()
                {
                    Id = sessionId,
                    Name = $"Séance de {10+j }h à {11+j}h",
                    Description = "Séance de fitness",
                    MaxBooking = 3,
                    ImagePath = "",
                    Bookings = new List<Booking>(),
                    StartTime = new DateTime(2023, 10, 27, 10+j, 0, 0),
                    FinishTime = new DateTime(2023, 10, 27, 11+j, 0, 0),
                    SportCategoryId = 1,
                    GymId = 1
                };
                gymSession.Add(a);
                sessionId++;
            }


            builder.Entity<Session>().HasData(gymSession);

            var gym = new List<Gym>()
            {
                new Gym()
                {
                    Id = 1,
                    Name = "Fitness Park",
                    Address = "1 rue Lille, 59000 Lille",
                    Phone = "0608090909"
                },
                new Gym()
                {
                    Id = 2,
                    Name = "BasicFit",
                    Address = "1 rue Roubaix, 59100 Roubaix",
                    Phone = "0608090909"
                },
                new Gym()
                {
                    Id = 3,
                    Name = "Kipstadium",
                    Address = "1 rue Tourcoing, 59000 Tourcoing",
                    Phone = "0608090909"
                },
                new Gym()
                {
                    Id = 4,
                    Name = "UrbanSoccer",
                    Address = "1 rue Bondu, 59000 Bondu",
                    Phone = "0608090909"
                },
            };


            builder.Entity<Gym>().HasData(gym);
        }
    }
}