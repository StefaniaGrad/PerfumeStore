using Microsoft.EntityFrameworkCore;
using PerfumeStore.Domain.IRepositories;
using PerfumeStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Dal.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly PerfumeStoreContext context;
        private readonly DbSet<TEntity> dbSet;

        protected GenericRepository(PerfumeStoreContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return dbSet.Any(predicate);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null)
        {
            if (predicate == null)
                return dbSet.ToList();

            return dbSet.Where(predicate).ToList();
        }

        public TEntity GetEntityBy(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.SingleOrDefault(predicate);
        }

        public TEntity GetEntityById(Guid id)
        {
            return dbSet.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
