using System.ComponentModel.DataAnnotations;

namespace TP2_6216948_PWS.Models
{
    public class DG
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual Team Equipe { get; set; }

    }
}
