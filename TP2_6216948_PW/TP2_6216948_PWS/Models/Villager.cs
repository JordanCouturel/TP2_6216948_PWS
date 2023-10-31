using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP2_6216948_PWS.Models
{
    public class Villager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [JsonIgnore]
        public virtual List<User>? UsersFriends { get; set; }
    }
}
