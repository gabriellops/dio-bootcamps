namespace MinimalAPI.Domain.Contracts.Requests
{
    public record AdministratorRequest(string Email, string Senha, string Role);
}
