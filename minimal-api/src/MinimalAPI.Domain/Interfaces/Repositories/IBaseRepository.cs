using System.Linq.Expressions;

namespace MinimalAPI.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> ListAsync();
        Task<T> FindAsync(int id);
        Task<T?> FindAsync(Expression<Func<T, bool>> expression);
        Task<T> FindAsNoTrackingAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entidade);
        Task UpdateAsync(T entidade);
        Task RemoveAsync(T entidade);
    }
}
