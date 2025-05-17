namespace online_journal.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }

        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
    }
}
