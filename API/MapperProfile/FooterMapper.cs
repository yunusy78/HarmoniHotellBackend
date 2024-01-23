using AutoMapper;
using DtoLayer.FooterDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class FooterMapper : Profile
{
    public FooterMapper()
    {
        CreateMap<Footer, CreateFooterDto>().ReverseMap();
        CreateMap<Footer, UpdateFooterDto>().ReverseMap();
        CreateMap<Footer, ResultFooterDto>().ReverseMap();
        CreateMap<Footer, GetFooterDto>().ReverseMap();
    }
    
    
    
}