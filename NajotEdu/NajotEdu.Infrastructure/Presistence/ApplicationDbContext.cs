using Microsoft.EntityFrameworkCore;
using NajotEdu.Domain.Entities;
using NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration;

namespace NajotEdu.Infrastructure.Presistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Attendence> Attendences { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AttendenceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GroupEntityTupeConfiguration());
            modelBuilder.ApplyConfiguration(new LessonEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new StudentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new StudentGroupEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserTypeCofiguration());
        }
    }
}
