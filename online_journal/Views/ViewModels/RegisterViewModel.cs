using System.ComponentModel.DataAnnotations;

namespace online_journal.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nomatonro doxil kardan shart")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Nasabatonro doxil kardan shart")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email doxil kardan shart")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Parol doxil kardan shart")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Parol nodurust")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
