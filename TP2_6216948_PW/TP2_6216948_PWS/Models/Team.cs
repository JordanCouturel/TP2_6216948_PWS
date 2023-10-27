using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TP2_6216948_PWS.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ville { get; set; }

        public string Commanditaire { get; set; }

        //prop nav
    
        [ForeignKey("League")]
        public int LeagueId { get; set; }
        [JsonIgnore]
        public virtual League League { get; set; }




        [ForeignKey("Arena")]
        public int ArenaID { get; set; }
        [JsonIgnore]
        public virtual Arena Arena { get; set; }


        [ForeignKey("DG")]
        public int DGId { get; set; }
        [JsonIgnore]
        public virtual DG? DG { get; set; }

    }
}
