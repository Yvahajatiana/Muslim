using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muslim.Core.Domain
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> GetByIdAsync(object id);

        Task<IEnumerable<T>> ListAllAsync(Expression<Func<T, bool>> predicate);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
