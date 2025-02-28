using System.ComponentModel.DataAnnotations;

namespace Saturn.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Your name is required Please😉")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your email is Requiered😎")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Make a password Youll defintly forget!😊")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The {0} must be at {2} and at max {1} Charactors long")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword", ErrorMessage ="😏😏Nice try Budd! but try again shall we.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You forgot to confirm your PassWord😫")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
       
    }
}
