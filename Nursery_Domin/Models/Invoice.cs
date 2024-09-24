using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Domin.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
        public decimal Price { get; set; }
    }
}
