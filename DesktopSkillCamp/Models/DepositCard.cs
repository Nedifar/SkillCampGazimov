using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class DepositCard
    {
        public int idDepositCard { get; set; }
        public string CardIssuer { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardExpDate { get; set; }
        public double Balance { get; set; }
        public string CardHolder { get; set; }
        public int idCartType { get; set; }
        public virtual CardType CardType { get; set; }
    }
}
