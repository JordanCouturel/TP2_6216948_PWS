using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TP2_6216948_PWS.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        //prop nav
        [JsonIgnore]
        public virtual List<Team>? Teams { get; set; }
        [JsonIgnore]
        public virtual List<Saison>? Saisons { get; set; }


    }
}
