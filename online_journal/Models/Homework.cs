namespace online_journal.Models
{
    public class Homework
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DueDate { get; set; }

        public Subject? Subject { get; set; }
    }
}
