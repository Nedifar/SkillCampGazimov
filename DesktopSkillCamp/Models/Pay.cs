using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class Pay
    {
        public int idPay { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public string OrganizationName { get; set; }
        public int idStation { get; set; }
        public virtual GasStation GasStation { get; set; }
        public string key { get; set; }
    }
}
