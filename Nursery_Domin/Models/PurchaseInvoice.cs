using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class PurchaseInvoice
    {
        public int PurchaseInvoiceId { get; set; }
        public int PlantId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public List<Plant> Plants { get; set; }=new List<Plant>();

    }
}
