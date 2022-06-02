namespace DemoEmployee.DTOs
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }
       // public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
        //public virtual ICollection<Photo>? Photos { get; set; } = new List<Photo>();
        public string? Name { get; set; }
        public string Address { get; set; }

    }
}
