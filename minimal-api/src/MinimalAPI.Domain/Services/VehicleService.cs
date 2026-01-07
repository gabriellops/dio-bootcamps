using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Domain.Interfaces.Services;

namespace MinimalAPI.Domain.Services
{
    public class VehicleService : BaseService<VehicleEntity>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository) : base(vehicleRepository) => _vehicleRepository = vehicleRepository;

        public async Task<List<VehicleEntity>> BuscarTodosPaginacaoAsync(int? pagina = 1, string? nome = null, string? marca = null)
        {
            if (pagina.HasValue && pagina <= 0)
            {
                throw new ArgumentException("A página deve ser maior que zero.", nameof(pagina));
            }

            if (!string.IsNullOrWhiteSpace(nome) && nome.Length < 2)
            {
                throw new ArgumentException("Nome deve ter pelo menos 2 caracteres.");
            }

            return await _vehicleRepository.ListPaginationAsync(pagina, nome, marca);
        }
    }
}
