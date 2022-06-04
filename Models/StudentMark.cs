namespace DemoEmployee.Models
{
    public class StudentMark
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }//fk
        public string ExamName { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public virtual Student Student { get; set; }    

    }
}
