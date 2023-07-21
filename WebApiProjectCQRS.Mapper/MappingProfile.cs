using AutoMapper;
using WebApiProjectCQRS.Domain;
using WebApiProjectCQRS.Request.Command;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee, EmployeeResponse>();
            CreateMap<Employee, CommandInsertEmployeeDetails>();
        }

    }
}