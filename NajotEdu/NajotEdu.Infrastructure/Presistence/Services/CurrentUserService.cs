using Microsoft.AspNetCore.Http;
using NajotEdu.Application.Abstraction;
using System.Security.Claims;

namespace NajotEdu.Infrastructure.Services
{
    // hozirgi murojaatda kim ekanini aniqlab beruvchi service 
    public class CurrentUserService : ICurrentUserService
    {
        public int UserId { get; set; }
        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            if (int.TryParse(contextAccessor!.HttpContext.User.Claims
                .FirstOrDefault(a => a.Type == ClaimTypes.Name)!.ValueType, out int value))
            {
                UserId = value;
            };
        }

    }
}
