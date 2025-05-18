namespace online_journal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Role { get; set; } = null!; // Teacher, Student, Parent, Admin

        public ICollection<Student>? Students { get; set; }
        public string? Password { get; internal set; }
    }
}
