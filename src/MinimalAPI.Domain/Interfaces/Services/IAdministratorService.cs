using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Domain.Interfaces.Services
{
    public interface IAdministratorService
    {
        Task<List<AdministratorEntity>> BuscarTodosPaginacaoAsync(int? pagina);
    }
}
