using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public Customer? User { get; set; }

        public string ?OrderNumber { get; set; }
        public string? Item { get; set; }
        public int? Price { get; set; }
        public int? Qnty { get; set; }


    }
}
