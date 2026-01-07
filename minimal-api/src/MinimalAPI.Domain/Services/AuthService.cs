using MinimalAPI.Domain.Entities;
using MinimalAPI.Domain.Interfaces.Repositories;

namespace MinimalAPI.Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAdministratorRepository _administratorRepository;

        public AuthService(IAdministratorRepository administratorRepository) => _administratorRepository = administratorRepository;

        private async Task<AdministratorEntity> BuscaAdministratorOrFail(string email)
        {
            var administrator = await _administratorRepository.FindAsync(x => x.Email.Equals(email));

        }
    }
}
