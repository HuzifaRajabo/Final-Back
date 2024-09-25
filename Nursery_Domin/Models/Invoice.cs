using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Domin.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
        public decimal Price { get; set; }
        public bool IsSeld { get; set; }
    }
}
