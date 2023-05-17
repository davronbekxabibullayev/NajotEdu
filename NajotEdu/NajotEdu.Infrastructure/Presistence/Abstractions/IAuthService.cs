namespace NajotEdu.Infrastructure.Presistence.Apsructions
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string username, string password);
    }
}
