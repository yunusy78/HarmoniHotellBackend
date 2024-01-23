using AutoMapper;
using DtoLayer.RoomDtos;
using Entity.Concrete;


namespace API.MapperProfile;

public class RoomMapper : Profile
{
    public RoomMapper()
    {
        CreateMap<Room, CreateRoomDto>().ReverseMap();
        CreateMap<Room, UpdateRoomDto>().ReverseMap();
        CreateMap<Room, ResultRoomDto>().ReverseMap();
        CreateMap<Room, GetRoomDto>().ReverseMap();
        CreateMap<Room, ResultRoomWithCategoryDto>().ReverseMap();
    }
    
}