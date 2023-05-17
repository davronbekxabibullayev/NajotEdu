using Microsoft.AspNetCore.Mvc;
using NajotEdu.API.Models;
using NajotEdu.Infrastructure.Presistence.Apsructions;

namespace NajotEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginRequest loginRequest)
        {
            var token = await _authService.LoginAsync(loginRequest.UserName, loginRequest.Password);
            return Ok(token);
        }
    }

}
