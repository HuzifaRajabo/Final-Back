using Nursery.Infrastructure.DBContext;
using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class SaleInvoiceRepository : GenericRepository<SaleInvoice>
    {
        public SaleInvoiceRepository(NurseryDbContext context) : base(context)
        {
        }
    }
}
