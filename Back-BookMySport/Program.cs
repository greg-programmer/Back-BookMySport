using Back_BookMySport.Data;
using Back_BookMySport.Helper;
using Back_BookMySport.Models;
using Back_BookMySport.Repositories;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthorization();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRepository<Booking>, BookingService>();
builder.Services.AddScoped<IRepository<Session>, SessionService>();
builder.Services.AddScoped<IRepository<SportCategory>, SportService>();
builder.Services.AddScoped<Settings>();
builder.Services.AddIdentityCore<User>(options  =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
})
            .AddEntityFrameworkStores<ApplicationDbContext>();  
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookingMySport", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Type = SecuritySchemeType.Http
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                    }
                });
});
// Authentication
// on récupère la section AppSettings du fichier appsettings.json
var appSettingsSection = builder.Configuration.GetSection(nameof(Settings));
// on l'enregistre dans nos services (utile pour la partie login/register)
builder.Services.Configure<Settings>(appSettingsSection); // => donne un IOption<AppSettings> dans le conteneur de dépendances
                                                             // on récupère la section pour program.cs
Settings appSettings = appSettingsSection.Get<Settings>();
// on r�cup�re la cl� et on l'encode
var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // utilisation d'une clé cryptée pour la sécurité du token
            IssuerSigningKey = new SymmetricSecurityKey(key), // clé cryptée en elle même
            ValidateLifetime = true, // vérification du temps d'expiration du Token
            ValidateAudience = true, // vérification de l'audience du token
            ValidAudience = appSettings.ValidAudience, // l'audience
            ValidateIssuer = true, // vérification du donneur du token
            ValidIssuer = appSettings.ValidIssuer, // le donneur
            ClockSkew = TimeSpan.Zero // décallage possible de l'expiration du token
        };
    });
// ajouter le service IMapper de AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();

app.Run();
