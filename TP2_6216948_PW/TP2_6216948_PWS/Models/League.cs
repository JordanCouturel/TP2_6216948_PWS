using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        //prop nav
        public virtual List<Team> Teams { get; set; }

        public virtual List<Saison> Saisons { get; set; }


    }
}
