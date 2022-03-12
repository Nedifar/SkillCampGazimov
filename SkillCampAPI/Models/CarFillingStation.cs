using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class CarFillingStation
    {
        [Key]
        public int idCarFillingStation { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int AmountOfFuel { get; set; }
        [ForeignKey("GasStation")]
        public int GasStation_idStation { get; set; }
        [JsonIgnore]
        public virtual GasStation GasStation { get; set; }
    }
}
