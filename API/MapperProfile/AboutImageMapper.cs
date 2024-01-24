using AutoMapper;
using DtoLayer.AboutImageDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class AboutImageMapper : Profile
{
    public AboutImageMapper()
    {
        CreateMap<AboutImage, CreateAboutImageDto>().ReverseMap();
        CreateMap<AboutImage, UpdateAboutImageDto>().ReverseMap();
        CreateMap<AboutImage, ResultAboutImageDto>().ReverseMap();
        CreateMap<AboutImage, GetAboutImageDto>().ReverseMap();
    }
    
}