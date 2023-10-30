using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class LoginDTO
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
