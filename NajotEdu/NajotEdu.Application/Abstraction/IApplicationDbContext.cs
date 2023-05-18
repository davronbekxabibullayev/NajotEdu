using Microsoft.EntityFrameworkCore;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Abstraction
{
    // bu orqali biz prinspialni ishlagan
    // bulamiz va dbcontext qayerda kerak
    // bulsa shu orqali chaqirib olib ishlataveramiz
    public interface IApplicationDbContext
    {
        DbSet<Attendence> Attendences { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Lesson> Lessons { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<StudentGroup> StudentGroups { get; set; }
        DbSet<User> Users { get; set; }

        // bu yerdas int nechta uzgarish bulganini qaytaradi
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
