using DemoEmployee.Models;
using DemoEmployee.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee2Controller : ControllerBase
    {
        IEmployeeService employeeService; 
        public Employee2Controller(IEmployeeService employeeService)
        {
        this.employeeService = employeeService;
        }
    [HttpPost]
    public void AddEmployee(Employee employee)
    {
        //call a service
        employeeService.Insert(employee);
    }
        [HttpGet]
        public Employee GetEmployee(Guid id)
        {
            
            var employee=employeeService.GetById(id);
            return employee;
        }
        
        

        


    }


}
