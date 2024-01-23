using AutoMapper;
using DtoLayer.ServiceDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class ServiceMapper : Profile
{
    public ServiceMapper()
    {
        CreateMap<Service, CreateServiceDto>().ReverseMap();
        CreateMap<Service, UpdateServiceDto>().ReverseMap();
        CreateMap<Service, ResultServiceDto>().ReverseMap();
        CreateMap<Service, GetServiceDto>().ReverseMap();
        
    }
    
}