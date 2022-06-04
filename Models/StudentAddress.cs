namespace DemoEmployee.Models
{
    public class StudentAddress
    {
        public Guid Id { get; set; }
        
        public string StreetName{ get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public virtual Student ?Student { get; set; }

    }
}
