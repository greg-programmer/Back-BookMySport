using AutoMapper;
using Back_BookMySport.DTOS;
using Back_BookMySport.Models;

namespace Back_BookMySport.Helpers
{
    public class MaperProfile : Profile
    {
         public MaperProfile() 
        {
            CreateMap<User, RegisterRequestDTO>().ReverseMap();
            CreateMap<User, LoginRequestDTO>().ReverseMap();
            CreateMap<User, GetUserDTO>().ReverseMap();
        }
    }
}
