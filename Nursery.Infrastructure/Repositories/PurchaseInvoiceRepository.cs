using Nursery.Infrastructure.DBContext;
using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class PurchaseInvoiceRepository : GenericRepository<PurchaseInvoice>
    {
        public PurchaseInvoiceRepository(NurseryDbContext context) : base(context)
        {
        }
    }
}
