using DemoEmployee.Models;

namespace DemoEmployee.Services.Interface
{
    public interface IEmployeeService
    {

        public void Insert(Employee employee);
        public Employee GetById(Guid id);    

    }
}
