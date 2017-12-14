using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muslim.Core.Domain.Common
{
    public abstract class CrudService<T> where T: class, IEntity
    {
        protected readonly IRepository<T> _repository;

        public CrudService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task Create(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task Delete(T entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _repository.ListAllAsync(predicate);
        }

        public async Task Update(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
