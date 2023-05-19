using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.Apsructions
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user);
    }
}
