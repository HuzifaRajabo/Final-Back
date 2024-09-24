using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Domin.Models
{
    public class Plant
    {
        public Guid Id { get; set; }
        public string Barcode { get; set; }
        public string Source { get; set; } // Imported or Locally Grown
        public DateTime BirthDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? DisposalDate { get; set; }
        public Guid kindId { get; set; }
        public Kind kind { get; set; }
    }
}
