using DemoEmployee.db;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;

namespace DemoEmployee.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _context;
        public EmployeeService( EmployeeDbContext context)
        {
            _context = context; 
        }
        public Employee GetById(Guid id)
        {
            try
            {
                var employee = _context.Employee.Find(id);
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }

        public void Insert(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }
        public List<Employee> GetAll()
        {
            
            return _context.Employee.ToList();  
        }

    }
}
