using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NajotEdu.Domain.Entities;
using NajotEdu.Infrastructure.Presistence.Apsructions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NajotEdu.Infrastructure.Presistence.Services
{
    public class JWTService : ITokenService

    {
        private readonly IConfiguration _configuration;
        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateAccessToken(User user)
        {
            var claims = new Claim[]
            {
                //new Claim(JwtRegisteredClaimNames.UniqueName, user.Id.ToString()), // buni teacherId attendance qilayotgan
                                                                                    // teacherning Id siga tugri kelishi
                                                                                    // kerakligi uchun qushdik
                new Claim(JwtRegisteredClaimNames.Name, user.Id.ToString()),        // Bu yerda user.Id sini
                                                                                    // JwtRegisteredClaimNames.Namega biriktirib quydik 
                                                                                    // va filtrqilganimizda shunga qarab tekshirib olamiz
                new Claim("Role", user.Role.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var credentials /* bu appsetting.json faylidagi kalit suzimizni _configuration orqali uqib olib */
                = new SigningCredentials(
                new SymmetricSecurityKey/* bu kalit suzini(shifr) oladi bytga ugirib*/
                (Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])), // your SecretKey  mustn't be less then 128 bits
                SecurityAlgorithms/* bu esa olingan shifrni shu algaritm buyicha hashlaydi*/
                .HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["JWT:ValidIssuer"],
                _configuration["JWT:ValidAudience"],
                claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
                );

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token)/* shu yerda token generate buldi */;
        }
    }
}
