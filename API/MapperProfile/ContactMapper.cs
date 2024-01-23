using AutoMapper;
using DtoLayer.MessageDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class ContactMapper : Profile
{
    public ContactMapper()
    {
        CreateMap<Contact, CreateMessageDto>().ReverseMap();
        CreateMap<Contact, UpdateMessageDto>().ReverseMap();
        CreateMap<Contact, ResultMessageDto>().ReverseMap();
        CreateMap<Contact, GetMessageDto>().ReverseMap();
    }
    
}