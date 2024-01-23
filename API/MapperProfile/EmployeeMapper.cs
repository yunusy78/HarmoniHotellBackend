using AutoMapper;
using DtoLayer.EmployeeDtos;
using Entity.Concrete;

namespace API.MapperProfile;

public class EmployeeMapper : Profile
{
    public EmployeeMapper()
    {
        CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();
        CreateMap<Employee, ResultEmployeeDto>().ReverseMap();
        CreateMap<Employee, GetEmployeeDto>().ReverseMap();
    }
    
    
    
}