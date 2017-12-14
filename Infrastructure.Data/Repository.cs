using Microsoft.EntityFrameworkCore;
using Muslim.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muslim.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T :class, IEntity
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            var result = await _context.Set<T>().FindAsync(id);

            return result;
        }

        public async Task<IEnumerable<T>> ListAllAsync(Expression<Func<T,bool>> predicate = null)
        {
            var result = await _context.Set<T>().Where(predicate).ToListAsync();

            return result;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
