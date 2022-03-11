using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class Purchase
    {
        public int idPurchase { get; set; }
        public string CardHolder { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int idStation { get; set; }
        public virtual GasStation GasStation { get; set; }
        public string FuelType { get; set; }
        public double Value { get; set; }
        public double Cost { get; set; }
        public string PaymentType { get; set; }
    }
}
