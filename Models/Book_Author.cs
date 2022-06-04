namespace DemoEmployee.Models
{
    public class Book_Author
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }//fk
        public Guid AuthorId { get; set; }//fk
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
