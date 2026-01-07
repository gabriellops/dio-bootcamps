using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Domain.Interfaces.Repositories
{
    public interface IAdministratorRepository : IBaseRepository<AdministratorEntity>
    {
        Task<List<AdministratorEntity>> ListPaginationAsync(int? pagina);
    }
}
