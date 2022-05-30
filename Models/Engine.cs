using System.ComponentModel.DataAnnotations;

namespace DemoEmployee.Models
{
    public class Engine
    {
        [Key]
        public Guid Id { get; set; }
        public string ? Name { get; set; }
        public int ? StrokeNumber { get; set; }
    }
}
