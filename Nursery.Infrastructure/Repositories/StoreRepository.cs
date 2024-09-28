using Microsoft.EntityFrameworkCore;
using Nursery.Domin.Models;
using Nursery.Infrastructure.DBContext;
using Nursery.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        private readonly NurseryDbContext context;

        public StoreRepository(NurseryDbContext context) : base(context)
        {
            this.context = context;
        }

        public void nagativeAmmount(int plantId, int amount)
        {
            var store = context.Stores.FirstOrDefault(p => p.PlantId == plantId);
            if (store != null)
            {
                store.Amount -= amount;
                context.SaveChanges();
            }
        }

        public void addAmmount(int plantId, int amount)
        {
            var store = context.Stores.FirstOrDefault(p => p.PlantId == plantId);
            if (store != null)
            {
                store.Amount += amount;
                context.SaveChanges();
            }
        }

        public void addPlant(int plantId, int amount)
        {
            Store store = new Store();
            store.PlantId = plantId;
            store.Amount += amount;
            context.Add(store);
           // context.SaveChanges();
           context.SaveChangesAsync();
        }

        
    }
}
