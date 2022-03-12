using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class DepositCard
    {
        [Key]
        public int idDepositCard { get; set; }
        public string CardIssuer { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardExpDate { get; set; }
        public double Balance { get; set; }
        public string CardHolder { get; set; }
        [ForeignKey("CardType")]
        public int idCartType { get; set; }
        public virtual CardType CardType { get; set; }
    }
}
