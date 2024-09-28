using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class SectorPlant
    {
        public int PlantId { get; set; }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
        public Plant Plant { get; set; }
    }
}
