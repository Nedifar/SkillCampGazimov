using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class Pay
    {
        [Key]
        public int idPay { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public string OrganizationName { get; set; }
        [ForeignKey("GasStation")]
        public int idStation { get; set; }
        [JsonIgnore]
        public virtual GasStation GasStation { get; set; }
        public string key { get; set; }
    }
}
