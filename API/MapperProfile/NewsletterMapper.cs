using AutoMapper;
using DtoLayer.NewsletterDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class NewsletterMapper : Profile
{
    public NewsletterMapper()
    {
        CreateMap<Newsletter, CreateNewsletterDto>().ReverseMap();
        CreateMap<Newsletter, UpdateNewsletterDto>().ReverseMap();
        CreateMap<Newsletter, ResultNewsletterDto>().ReverseMap();
        CreateMap<Newsletter, GetNewsletterDto>().ReverseMap();
    }
    
    
    
}