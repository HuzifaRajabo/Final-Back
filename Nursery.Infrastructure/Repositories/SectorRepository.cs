using Nursery.Infrastructure.DBContext;
using Nursery_Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class SectorRepository : GenericRepository<Sector>
    {
        public SectorRepository(NurseryDbContext context) : base(context)
        {
        }
    }
}
