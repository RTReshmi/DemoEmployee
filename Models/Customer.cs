using System.ComponentModel.DataAnnotations;

namespace DemoEmployee.Models
{
    public class Customer
    {
        [Key]
        public Guid Id{ get; set; }
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();    
        public string ?Name {get; set; }
        public string Address { get; set; }
       

    }
}
