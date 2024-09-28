using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public List<Kind> kinds { get; set; } = new List<Kind>();
        public List<SectorPlant> Sectorplants { get; set; } = new List<SectorPlant> ();

       
    }
}
