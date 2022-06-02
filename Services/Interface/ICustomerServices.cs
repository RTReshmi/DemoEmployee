using DemoEmployee.DTOs;
using DemoEmployee.Models;

namespace DemoEmployee.Services.Interface
{
    public interface ICustomerServices
    {
        public CustomerDTO AddCustomer(CustomerDTO customerdto);
        public CustomerDTO GetCustomer(Guid Id);
        public CustomerDTO UpdateCustomer(CustomerDTO customerdto);
        public CustomerDTO DeleteCustomer(CustomerDTO customerdto);

    }
}
