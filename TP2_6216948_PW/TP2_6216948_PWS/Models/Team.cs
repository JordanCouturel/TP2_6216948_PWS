using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public virtual League League { get; set; }




        [ForeignKey("Arena")]
        public int ArenaID { get; set; }

        public virtual Arena Arena { get; set; }


        [ForeignKey("DG")]
        public int DGId { get; set; }

        public virtual DG DG { get; set; }

    }
}
