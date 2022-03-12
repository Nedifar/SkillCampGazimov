using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class GasStation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idStation { get; set; }
        public string Address { get; set; }
        public virtual List<CarFillingStation> CarFillingStations { get; set; } = new List<CarFillingStation>();
        [JsonIgnore]
        public virtual List<Pay> Pays { get; set; } = new List<Pay>();
        [JsonIgnore]
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
