namespace DemoEmployee.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }//fk
        
        public string Name { get; set; }
        public int Standard { get; set; }
        public virtual StudentAddress ?StudentAddress { get; set; } 
        public virtual ICollection<StudentMark> ?StudentMarks { get; set; }=new List<StudentMark>();
    }
}
