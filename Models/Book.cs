namespace DemoEmployee.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public ICollection<Book_Author> Book_Authors { get; set; }




    }
}
