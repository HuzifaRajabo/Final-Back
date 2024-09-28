using Nursery.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Interfaces
{
    public interface IStoreRepository : IRepository<Store>
    {
        void nagativeAmmount(int plantId, int amount);
        void addAmmount(int plantId, int amount);
        void addPlant (int plantId, int amount);
    }
}
