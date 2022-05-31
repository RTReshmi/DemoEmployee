using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Photo
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public Guid CustomerId { get; set; }    
        public virtual Customer ? Customer { get; set; }
        public string Name { get; set; }
        public string URL{ get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;    

    }
}
