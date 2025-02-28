using System.ComponentModel.DataAnnotations;

namespace Saturn.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Your email is Requiered😎")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Make a password Youll defintly forget!😊")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} Charactors long")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "😏😏Nice try Budd! but try again shall we.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "You forgot to confirm your New PassWord😫")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm the New Password buddy!😌")]

        public string ConfirmNewPassword { get; set; }
       
    }
}
