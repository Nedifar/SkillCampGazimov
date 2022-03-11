using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class GasStation
    {
        public int idStation { get; set; }
        public string Address { get; set; }
        public virtual List<CarFillingStation> CarFillingStations { get; set; } = new List<CarFillingStation>();
    }
}
