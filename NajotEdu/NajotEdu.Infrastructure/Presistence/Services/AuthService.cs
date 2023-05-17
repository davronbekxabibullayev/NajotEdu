using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Infrastructure.Presistence.Apsructions;

namespace NajotEdu.Infrastructure.Presistence.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly ITokenService _tokenService;
        private readonly IHashProvider _hashProvider;

        public AuthService(ApplicationDbContext context, ITokenService tokenService, IHashProvider hashProvider)
        {
            _DbContext = context;
            _tokenService = tokenService;
            _hashProvider = hashProvider;
        }
        public async Task<string> LoginAsync(string username, string password)
        {
            var user = await _DbContext.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                throw new Exception("bu user yuq");
            }

            else if (user.PasswordHash != _hashProvider.GetHash(password))
            {
                throw new Exception("Your password is wrong!!!");
            }

            else return _tokenService.GenerateAccessToken(user);
        }
    }
}