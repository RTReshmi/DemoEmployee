using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }


        [ForeignKey("Id")]
        public Guid EngineId { get; set; }
        public virtual Engine ? engine { get; set; }  


        public string Name { get; set; }
        public string Colour { get; set; }
        public int Mileage { get; set; }
        
    }
}
