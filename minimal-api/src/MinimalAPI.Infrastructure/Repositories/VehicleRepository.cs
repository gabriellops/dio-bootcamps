using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Infrastructure.Contexts;

namespace MinimalAPI.Infrastructure.Repositories
{
    public class VehicleRepository : BaseRepository<VehicleEntity>, IVehicleRepository
    {
        private readonly MinimalContext _context;

        public VehicleRepository(MinimalContext context) : base(context) => _context = context;

        public async Task<List<VehicleEntity>> ListPaginationAsync(int? pagina = 1, string? nome = null, string? marca = null)
        {
            const int itensPorPagina = 10;

            var query = _context.VehicleEntities.AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                var nomeFiltro = nome.Trim().ToUpper();
                query = query.Where(v => EF.Functions.Like(v.Nome.ToUpper(), $"%{nomeFiltro}%"));
            }

            query = query.OrderBy(v => v.Id);

            if (pagina.HasValue && pagina.Value > 0)
            {
                query = query.Skip((pagina.Value - 1) * itensPorPagina)
                             .Take(itensPorPagina);
            }

            return [.. query];
        }
    }
}
