namespace DemoEmployee.DTOs
{
    public class TeacherDTO
    {
        public Guid Id { get; set; }
        
        public Guid DepartmentId { get; set; }
        //public virtual Department? department { get; set; }


        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

    }
}
