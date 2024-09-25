using Nursery.Infrastructure.DBContext;
using Nursery_Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        public InvoiceRepository(NurseryDbContext context) : base(context)
        {
        }
    }
}
