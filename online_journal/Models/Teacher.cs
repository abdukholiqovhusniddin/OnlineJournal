namespace online_journal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int SubjectId { get; set; }
        public string PhoneNumber { get; set; } = null!;

        public Subject? Subject { get; set; }
    }
}
