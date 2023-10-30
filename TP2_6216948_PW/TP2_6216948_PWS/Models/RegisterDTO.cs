using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirm { get; set; }
    }
}
