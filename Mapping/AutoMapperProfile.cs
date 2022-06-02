using AutoMapper;
using DemoEmployee.DTOs;
using DemoEmployee.Models;

namespace DemoEmployee.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap< Teacher,TeacherDTO>().ReverseMap();
            
        }   
    }
}
