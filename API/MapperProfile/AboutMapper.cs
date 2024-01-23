using AutoMapper;
using DtoLayer.AboutDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class AboutMapper : Profile
{
    public AboutMapper()
    {
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
    }
    
}