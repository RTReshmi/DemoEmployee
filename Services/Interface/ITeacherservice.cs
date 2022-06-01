using DemoEmployee.Models;
using DemoEmployee.ViewModel;

namespace DemoEmployee.Services.Interface
{
    public interface ITeacherservice
    {

        public TeacherViewModel Add(TeacherViewModel teacher);
       
        
        
        public List<Teacher> GetAll();
        public TeacherViewModel Get(Guid id);
    }
}
