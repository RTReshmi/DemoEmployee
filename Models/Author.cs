namespace DemoEmployee.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PenName { get; set; }
        public ICollection<Book_Author> Book_Authors { get; set; }

    }
}
