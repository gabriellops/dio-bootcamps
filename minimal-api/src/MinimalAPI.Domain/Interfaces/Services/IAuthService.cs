namespace MinimalAPI.Domain.Interfaces.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> AutenticarAsync(string email, string senha);

    }
}
