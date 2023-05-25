
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NajotEdu.Application.Abstraction;
using NajotEdu.Domain.Enum;
using NajotEdu.Infrastructure.Presistence;
using NajotEdu.Infrastructure.Presistence.Apsructions;
using NajotEdu.Infrastructure.Presistence.Services;
using NajotEdu.Infrastructure.Providers;
using System.Text;

namespace NajotEdu.Infrastructure
{
    public static class DependencyInjection
    {
        // Bu extention class bulib u orqali qurayotgan appimizni
        // build qilishdan oldin ularga kerakli servicelarni yaratib
        // add qilib quyamiz bundan proggrom.cs imizda code kupayib ketmaydi

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, JWTService>();
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IHashProvider, HashProvider>();

            // app.UseAuthentication(); - middlewarening nostroykasini qilamiz bu eng oddiylaridan

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidAudience = configuration["JWT:ValidAudience"],
                        ValidIssuer = configuration["JWT:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                    };
                });

            /*  
                app.UseAuthorization(); - middlewarening nostroykasini qilamiz bu eng oddiylaridan
                services.AddAuthorization bu holatda  services.AddAuthentication buning shartlaridan utib 
                olgandan kegin [Authorize(Policy = "AdminAction")] kabi atributlarni controllerning ustiga 
                yozib ketish kerak va shunda quyidagi shartni ham qanoatlantirsagini dasturga kira oladi.
                Agar atributni [Authorize] kabi yozilsa ham quyidagi shartlarga kirmaydi.
            */

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                {
                    policy.RequireClaim("Role", UserRole.Admin.ToString());
                });
            });
            
            // bu yerda bu ishimiz utib ketgan vaqt bilan ishlamayman deganini uchirib quyamiz
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
 
            return services;
        }
    }
}