using System.ComponentModel.DataAnnotations;

namespace online_journal.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email doxil kardan shart")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Parol doxil kardan shart")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
