using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Domin.Models
{
    public class Kind
    {
        public int KindId { get; set; }
        public string KindName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}
