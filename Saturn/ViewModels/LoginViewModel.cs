using System.ComponentModel.DataAnnotations;

namespace Saturn.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "You forgot to enter your Email!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "You forgot to enter your Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
