using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class Arena
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Ville { get; set; }

        public string Pays { get; set; }
       
        //prop nav
        public virtual Team Team { get; set; }
    }
}
