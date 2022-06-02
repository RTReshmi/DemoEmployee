using DemoEmployee.DTOs;

namespace DemoEmployee.Services.Interface
{
    public interface ITeacherService
    {
        public TeacherDTO AddTeacher(TeacherDTO teacher);   
        public TeacherDTO GetTeacher(Guid id);    
    }
}
