using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class LoyaltyCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iLoyaltyCard { get; set; }
        public string CardHolder { get; set; }
        public double Balance { get; set; }
    }
}
