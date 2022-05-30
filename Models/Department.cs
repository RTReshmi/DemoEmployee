using System.ComponentModel.DataAnnotations;

namespace DemoEmployee.Models
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; } 



        public string? Name { get; set; }
        public string? HOD { get; set; }
        public int? StaffNumber { get; set; }


    }
}
