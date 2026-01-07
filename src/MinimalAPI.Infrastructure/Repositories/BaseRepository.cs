using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Infrastructure.Contexts;
using System.Linq.Expressions;

namespace MinimalAPI.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MinimalContext _context;

        public BaseRepository(MinimalContext context) => _context = context;

        public async Task<List<T>> ListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<T> FindAsNoTrackingAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task AddAsync(T entidade)
        {
            await _context.Set<T>().AddAsync(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entidade)
        {
            _context.Set<T>().Update(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entidade)
        {
            _context.Set<T>().Remove(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
