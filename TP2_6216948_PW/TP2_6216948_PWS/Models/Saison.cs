using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP2_6216948_PWS.Models
{
    public class Saison
    {
        [Key]
        public int Id { get; set; }

        public string DateDebut { get; set; }

        public string DateFin { get; set; }

        public int Annee { get; set; }




        //prop nav
        [ForeignKey("League")]
        public int LeagueId { get; set; }

        public virtual League League { get; set; }


    }
}
