using Microsoft.Extensions.DependencyInjection;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Services;

namespace NajotEdu.Application
{
    public static class DependencyInjecktion
    {
        // Bu extention class bulib u orqali qurayotgan appimizni
        // build qilishdan oldin ularga kerakli servicelarni yaratib
        // add qilib quyamiz bundan proggrom.cs imizda code kupayib ketmaydi
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            return services;
        }
    }
}
