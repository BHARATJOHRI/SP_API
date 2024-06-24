using AutoMapper;
using DemoSP_Infrastructure.DTO;
using DemoSP_Model.Entity;

namespace Demo_SP
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
        CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
