using AutoMapper;
using DtoLayer.DiscountDtos;
using DtoLayer.FeatureDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class DiscountMapper : Profile
{
    public DiscountMapper()
    {
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
    }
    
    
    
    
}