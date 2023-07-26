using Microsoft.EntityFrameworkCore;
using SocialNetwork.DataAccessLayer.Context;
using SocialNetwork.RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.RepositoryLayer.Repositories
{
    public class BaseRepositoryAsync<T> : IBaseRepositoryAsync<T> where T : class
    {
        protected SocialNetworkContext DbContext;
        public IQueryable<T> Entities => DbContext.Set<T>();

        public BaseRepositoryAsync(SocialNetworkContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            DbContext.Entry(entity).CurrentValues.SetValues(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }
    }
}
