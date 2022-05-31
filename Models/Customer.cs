using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Orders = new List<Order>();
        }
        [Key]
        public Guid Id { get; set; }
        public  virtual ICollection<Order>? Orders { get; set;}



        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
