using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class Plant
    {
        public int PlantId { get; set; }
        public int Amount { get; set; }
        public bool IsRestaurant { get; set; } = false;
        public string PlantName { get; set; }
        public string Barcode { get; set; }
        public decimal PriceSel { get; set; }
        public decimal PricePay { get; set; }
        public string Source { get; set; } // Imported or Locally Grown
        public DateTime BirthDate { get; set; }
        public DateTime? DisposalDate { get; set; }
        public int PurchaseInvoiceId { get; set; }
        [NotMapped]

        public PurchaseInvoice PurchaseInvoice { get; set; }
        public int kindId { get; set; }
        [NotMapped]

        public Kind kind { get; set; }
        [NotMapped]
        public List<SectorPlant> SectorPlants { get; set; } = new List<SectorPlant> ();
        [NotMapped]

        public List<SaleInvoicePlant> SaleInvoicePlants { get; set; } = new List<SaleInvoicePlant> ();

    }
}
