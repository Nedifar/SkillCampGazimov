using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class Refund
    {
        [Key]
        public int idRefuend { get; set; }
        public string CardNumber { get; set; }
        public double Transaction { get; set; }
        public double Value { get; set; }
    }
}
