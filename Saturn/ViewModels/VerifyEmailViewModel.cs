using System.ComponentModel.DataAnnotations;

namespace Saturn.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Your email is Requiered😎")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
