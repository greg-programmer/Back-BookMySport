using System.Globalization;
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


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var sportCategory = new List<SportCategory>()
            {
                new SportCategory() { Id = 1, Name = "Fitness", Sessions = new List<Session>() },
                new SportCategory() { Id = 2, Name = "Basketball", Sessions = new List<Session>() },
                new SportCategory() { Id = 3, Name = "Football", Sessions = new List<Session>() },
                new SportCategory() { Id = 4, Name = "Boxe", Sessions = new List<Session>() },
                new SportCategory() { Id = 5, Name = "Volley", Sessions = new List<Session>() }
            };
            builder.Entity<SportCategory>().HasData(sportCategory);

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

            var sessionId = 1;
            var gymSession = new List<Session>();


            // séance pour GymId =1
            for (int dayNovember = 1; dayNovember < 31; dayNovember++)
            {
                string dayToString = dayNovember < 10 ? $"0{dayNovember}" : $"{dayNovember}";
                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de fitness",
                        MaxBooking = 3,
                        ImagePath = "/img/fitness.jpg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 1,
                        GymId = 1
                    };
                    gymSession.Add(a);
                    sessionId++;
                }

                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de Boxe",
                        MaxBooking = 3,
                        ImagePath = "/img/boxe.jpg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 4,
                        GymId = 1
                    };
                    gymSession.Add(a);
                    sessionId++;
                }
            }


            // séance pour GymId =2
            for (int dayNovember = 1; dayNovember < 31; dayNovember++)
            {
                string dayToString = dayNovember < 10 ? $"0{dayNovember}" : $"{dayNovember}";
                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de fitness",
                        MaxBooking = 3,
                        ImagePath = "/img/fitness2.jpg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 1,
                        GymId = 2
                    };
                    gymSession.Add(a);
                    sessionId++;
                }
            }


            // séance pour GymId =3
            for (int dayNovember = 1; dayNovember < 31; dayNovember++)
            {
                string dayToString = dayNovember < 10 ? $"0{dayNovember}" : $"{dayNovember}";
                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de football",
                        MaxBooking = 10,
                        ImagePath = "/img/football.jpeg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 3,
                        GymId = 3
                    };
                    gymSession.Add(a);
                    sessionId++;
                }

                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de basketball",
                        MaxBooking = 10,
                        ImagePath = "/img/basket.jpeg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 2,
                        GymId = 3
                    };
                    gymSession.Add(a);
                    sessionId++;
                }

                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de volley",
                        MaxBooking = 10,
                        ImagePath = "/img/volley.jpeg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 5,
                        GymId = 3
                    };
                    gymSession.Add(a);
                    sessionId++;
                }
            }


            // séance pour GymId =4
            for (int dayNovember = 1; dayNovember < 31; dayNovember++)
            {
                string dayToString = dayNovember < 10 ? $"0{dayNovember}" : $"{dayNovember}";
                for (int j = 0; j < 13; j++)
                {
                    var a = new Session()
                    {
                        Id = sessionId,
                        Name = $"Séance de {10 + j}h à {11 + j}h",
                        Description = "Séance de football",
                        MaxBooking = 10,
                        ImagePath = "/img/football.jpeg",
                        Bookings = new List<Booking>(),
                        StartTime = DateTime.Parse($"{dayToString}/11/2023 {10+j}:15:12",new CultureInfo("fr-FR", false)),
                        FinishTime = DateTime.Parse($"{dayToString}/11/2023 {11+j}:15:12",new CultureInfo("fr-FR", false)),
                        SportCategoryId = 3,
                        GymId = 4
                    };
                    gymSession.Add(a);
                    sessionId++;
                }
            }

            

            builder.Entity<Session>().HasData(gymSession);
        }
    }
}