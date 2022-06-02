using AutoMapper;
using DemoEmployee.Models;
using DemoEmployee.ViewModel;

namespace DemoEmployee.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Teacher, TeacherViewModel>().ReverseMap();
          








        }
    }
}
