using AutoMapper;
using DtoLayer.ReservationDtos;
using Entity.Concrete;


namespace API.MapperProfile;   

public class ReservationMapper : Profile
{
public ReservationMapper()
    {
        CreateMap<Reservation, CreateReservationDto>().ReverseMap();
        CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
        CreateMap<Reservation, ResultReservationDto>().ReverseMap();
        CreateMap<Reservation, GetReservationDto>().ReverseMap();
    }
    
    
    
    
}