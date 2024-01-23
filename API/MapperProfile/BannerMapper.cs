using AutoMapper;
using DtoLayer.BannerDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class BannerMapper : Profile
{
    public BannerMapper()
    {
        CreateMap<Banner, CreateBannerDto>().ReverseMap();
        CreateMap<Banner, UpdateBannerDto>().ReverseMap();
        CreateMap<Banner, ResultBannerDto>().ReverseMap();
        CreateMap<Banner, GetBannerDto>().ReverseMap();
    }
    
    
    
}