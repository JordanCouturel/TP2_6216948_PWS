using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TP2_6216948_PWS.Models
{
    public class User: IdentityUser
    {
    

        [JsonIgnore]
        public virtual List<Villager>? VillagersFriends { get; set; }


    }
}
