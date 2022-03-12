using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class CameraLoad
    {
        [Key]
        public int idCameraLoad { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public string stateNumber { get; set; }
        public string img { get; set; }
    }
}
