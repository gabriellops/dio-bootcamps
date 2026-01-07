using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Domain.Interfaces.Services;

namespace MinimalAPI.Domain.Services
{
    public class AdministratorService : BaseService<AdministratorEntity>, IAdministratorService
    {
        private readonly IAdministratorRepository _administratorRepository;

        public AdministratorService(IAdministratorRepository administratorRepository) : base(administratorRepository) => _administratorRepository = administratorRepository;

        public Task<List<AdministratorEntity>> BuscarTodosPaginacaoAsync(int? pagina)
        {
            if (pagina.HasValue || pagina <= 0)
            {
                throw new ArgumentException("A página deve ser maior que zero.", nameof(pagina));
            }

            return _administratorRepository.ListPaginationAsync(pagina);
        }
    }
}
