using PerfumeStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.IRepositories
{
    public interface IGenericRepository <T> where T : IEntity
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null);
        T GetEntityBy(Expression<Func<T, bool>> predicate);
        T GetEntityById(Guid id);
        bool Any(Expression<Func<T, bool>>? predicate = null);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        void SaveChanges();
    }
}
