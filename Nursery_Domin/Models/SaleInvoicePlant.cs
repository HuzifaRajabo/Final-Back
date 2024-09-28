using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Domin.Models
{
    public class SaleInvoicePlant
    {
        public int PlantId { get; set; }
        public int SaleInvoiceId { get; set; }
        public SaleInvoice SaleInvoice { get; set; }
        public Plant Plant { get; set; }
    }
}
