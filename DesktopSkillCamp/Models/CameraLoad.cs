using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopSkillCamp.Models
{
    public class CameraLoad
    {
        public int idCameraLoad { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public string stateNumber { get; set; }
        public string img { get; set; }
    }
}
