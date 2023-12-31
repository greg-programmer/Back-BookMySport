using AutoMapper;
using Back_BookMySport.DTOs;
using Back_BookMySport.DTOS;
using Back_BookMySport.Models;

namespace Back_BookMySport.Helper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
         CreateMap<Booking,BookingDTO>().ReverseMap();
        CreateMap<Session,SessionDTO>().ReverseMap();
        CreateMap<Session,SessionUserBookedDTO>().ReverseMap();
        CreateMap<SportCategory,SportCategoryDTO>().ReverseMap();
        CreateMap<Gym,GymDTO>().ReverseMap();
        CreateMap<User, RegisterRequestDTO>().ReverseMap();
        CreateMap<User, LoginRequestDTO>().ReverseMap();
        CreateMap<User, GetUserDTO>().ReverseMap();
    }
    
}