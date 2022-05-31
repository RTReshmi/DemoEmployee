using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public Guid CustomerId {get;set;}
        public virtual Customer ?Customer { get; set; }


        public string ?OrderName { get; set; }
        public int ? Quantity { get; set; }
        public float? Price { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;    


    }
}
