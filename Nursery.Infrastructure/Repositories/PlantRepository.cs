using Nursery.Infrastructure.DBContext;
using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class PlantRepository : GenericRepository<Plant>
    {
        public PlantRepository(NurseryDbContext context) : base(context)
        {
        }
    }
}
