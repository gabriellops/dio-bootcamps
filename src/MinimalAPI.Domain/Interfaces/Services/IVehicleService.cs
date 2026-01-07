using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Domain.Interfaces.Services
{
    public interface IVehicleService
    {
        Task<List<VehicleEntity>> BuscarTodosPaginacaoAsync(int? pagina = 1, string? nome = null, string? marca = null);
    }
}
