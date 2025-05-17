using System.Security.Claims;

namespace online_journal.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int ClassId { get; set; }
        public int? ParentId { get; set; }

        public Class? Class { get; set; }
        public User? Parent { get; set; }
    }
}
