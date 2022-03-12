using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class Purchase
    {
        [Key]
        public int idPurchase { get; set; }
        public string CardHolder { get; set; }
        public DateTime PurchaseDate { get; set; }
        [ForeignKey("GasStation")]
        public int idStation { get; set; }
        [JsonIgnore]
        public virtual GasStation GasStation { get; set; }
        public string FuelType { get; set; }
        public double Value { get; set; }
        public double Cost { get; set; }
        public string PaymentType { get; set; }
    }
}
