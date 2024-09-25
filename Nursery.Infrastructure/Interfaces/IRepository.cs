﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T?> Get(int id);
        Task<List<T>> GetAll();
        Task<T> Delete(T entity);
        void SaveChanges();
    }
}
