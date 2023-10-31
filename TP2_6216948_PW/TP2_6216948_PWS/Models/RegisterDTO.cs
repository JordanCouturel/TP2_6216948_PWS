using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PasswordConfirm is required")]
        public string PasswordConfirm { get; set; }
    }
}
