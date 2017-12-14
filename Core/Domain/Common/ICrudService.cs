using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muslim.Core.Domain.Common
{
    public interface ICrudService<T> where T : class, IEntity
    {
        Task Create(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate);
    }
}
