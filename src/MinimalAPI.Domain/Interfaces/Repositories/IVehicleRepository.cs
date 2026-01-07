using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Domain.Interfaces.Repositories
{
    public interface IVehicleRepository : IBaseRepository<VehicleEntity>
    {
        Task<List<VehicleEntity>> ListPaginationAsync(int? pagina = 1, string? nome = null, string? marca = null);
    }
}
