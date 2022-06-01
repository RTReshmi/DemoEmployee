using DemoEmployee.Models;

namespace DemoEmployee.Services.Interface
{
    public interface ITeacherservice
    {

        public Teacher Add(Teacher teacher);
        public List<Teacher> GetAll();
        public Teacher Get(Guid id);
    }
}
