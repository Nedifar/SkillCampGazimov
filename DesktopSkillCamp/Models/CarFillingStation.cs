using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class CarFillingStation
    {
        public int idCarFillingStation { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int AmountOfFuel { get; set; }
        public int GasStation_idStation { get; set; }
        public virtual GasStation GasStation { get; set; }
    }
}
