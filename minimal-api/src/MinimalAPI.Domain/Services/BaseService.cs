using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Domain.Interfaces.Services;
using System.Linq.Expressions;

namespace MinimalAPI.Domain.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository) => _baseRepository = baseRepository;

        public async Task<List<T>> BuscarTodosAsync()
        {
            return await _baseRepository.ListAsync();
        }

        public async Task<T?> BuscarPorIdAsync(int id)
        {
            var entity = await _baseRepository.FindAsync(x => x.Id == id);
            
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entidade com ID {id} não encontrada.");
            }

            return entity;
        }

        public async Task<T> BuscarAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await _baseRepository.FindAsync(expression);

            if (entity == null)
            {
                throw new KeyNotFoundException("Entidade não encontrada com a expressão fornecida.");
            }

            return entity;
        }

        public async Task AdicionarAsync(T entidade)
        {
            if (entidade == null)
                throw new ArgumentNullException(nameof(entidade), "Entidade não pode ser nula.");

            await _baseRepository.AddAsync(entidade);
        }

        public async Task AlterarAsync(T entidade)
        {
            var entity = await _baseRepository.FindAsNoTrackingAsync(x => x.Id == entidade.Id);
        }

        public async Task DeletarAsync(int id)
        {
            var entity = _baseRepository.FindAsync(id);
            
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entidade com ID {id} não encontrada.");
            }

            await _baseRepository.RemoveAsync(entity.Result);
        }
    }
}