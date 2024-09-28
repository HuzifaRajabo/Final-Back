using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class SaleInvoice
    {
        public int SaleInvoiceId { get; set; }
        public int PlantId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string CurrencyCodePlant { get; set; }
        public List<SaleInvoicePlant> SaleInvoicePlants { get; set; } = new List<SaleInvoicePlant>();  

    }
}
