using AutoMapper;
using DtoLayer.FeatureDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class FeatureMapper : Profile
{
    public FeatureMapper()
    {
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, GetFeatureDto>().ReverseMap();
    }
    
    
    
}