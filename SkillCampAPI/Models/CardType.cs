using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class CardType
    {
        [Key]
        public int idCardType { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual List<DepositCard> DepositCards { get; set; } = new List<DepositCard>();
    }
}
