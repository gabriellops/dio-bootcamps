using MinimalAPI.Domain.Enums;

namespace MinimalAPI.Domain.Contracts.Responses
{
    public record AdministratorResponse(int Id, string Email, ERole Role);
}
