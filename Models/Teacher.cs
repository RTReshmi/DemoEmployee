using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEmployee.Models
{
    public class Teacher
    {
        [Key]

        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public Guid DepartmentId { get; set; }
      public virtual Department? department { get; set; }


        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }


    }
}
