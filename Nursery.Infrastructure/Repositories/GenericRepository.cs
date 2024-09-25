using Microsoft.EntityFrameworkCore;
using Nursery.Infrastructure.DBContext;
using Nursery.Infrastructure.Interfaces;

namespace Nursery.Infrastructure.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly NurseryDbContext context;

        public GenericRepository(NurseryDbContext context)
        {
            this.context = context;
        }

        public async Task<T> Add(T entity)
        {
            var newEntity = await context.AddAsync(entity);
            return await Task.FromResult(newEntity.Entity);
        }
        public async Task<T> Update(T entity)
        {
            var newEntity = context.Update(entity);
            return await Task.FromResult(newEntity.Entity);

        }


        public async Task<T?> Get(int id)
        {
            var getById = await context.FindAsync<T>(id);
            return await Task.FromResult(getById);
        }

        public async Task<List<T>> GetAll()
        {
            var getAll = await context.Set<T>().ToListAsync();
            return await Task.FromResult(getAll);
        }

        public async Task<T> Delete(T entity)
        {
            var delete = context.Remove(entity).Entity;
            return await Task.FromResult(delete);
        }

        public void SaveChanges()
        {
            context.SaveChangesAsync();
        }
    }
}