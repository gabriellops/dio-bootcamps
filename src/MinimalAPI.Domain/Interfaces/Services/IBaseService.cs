using System.Linq.Expressions;

namespace MinimalAPI.Domain.Interfaces.Services
{
    public interface IBaseService<T>
    {
        Task<List<T>> BuscarTodosAsync();
        Task<T?> BuscarPorIdAsync(int id);
        Task<T> BuscarAsync(Expression<Func<T, bool>> expression);
        Task AdicionarAsync(T entidade);
        Task AlterarAsync(T entidade);
        Task DeletarAsync(int id);
    }
}
