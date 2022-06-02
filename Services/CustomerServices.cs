using DemoEmployee.db;
using DemoEmployee.DTOs;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;

namespace DemoEmployee.Services
{
    public class CustomerServices : ICustomerServices
    {
        EmployeeDbContext _dbContext;
        public CustomerServices(EmployeeDbContext dbContext)
        {
           _dbContext = dbContext;
        }
        public CustomerDTO AddCustomer(CustomerDTO customerdto)
        {
            Customer customer2 = new Customer();  
            customer2.Address = customerdto.Address;   
            customer2.Id = customerdto.Id;
            _dbContext.Customer.Add(customer2);
            _dbContext.SaveChanges();// must

            return customerdto;
        }

       
        public CustomerDTO GetCustomer(Guid id)
        {
            var result = _dbContext.Customer.Find(id);
            CustomerDTO customerDTO=new CustomerDTO();
            customerDTO.Id = result.Id;
            customerDTO.Address = result.Address;
            return customerDTO; 
            
        }
    }
}
