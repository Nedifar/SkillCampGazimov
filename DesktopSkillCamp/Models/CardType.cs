using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class CardType
    {
        public int idCardType { get; set; }
        public string Name { get; set; }
        public virtual List<DepositCard> DepositCards { get; set; } = new List<DepositCard>();
    }
}
