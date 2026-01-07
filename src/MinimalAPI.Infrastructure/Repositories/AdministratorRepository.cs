using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;
using MinimalAPI.Infrastructure.Contexts;

namespace MinimalAPI.Infrastructure.Repositories
{
    public class AdministratorRepository : BaseRepository<AdministratorEntity>, IAdministratorRepository
    {
        private readonly MinimalContext _context;

        public AdministratorRepository(MinimalContext context) : base(context) => _context = context;

        public async Task<List<AdministratorEntity>> ListPaginationAsync(int? pagina)
        {
            const int itensPorPagina = 10;

            return await _context.AdministratorEntities
                                 .Skip(((int)pagina - 1) * itensPorPagina)
                                 .Take(itensPorPagina)
                                 .ToListAsync();
        }
    }
}
