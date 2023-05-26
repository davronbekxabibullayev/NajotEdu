using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class AttendenceEntityTypeConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(a => a.Student).WithMany(a => a.Attenants).HasForeignKey(a => a.StudentId);
            builder.HasOne(a => a.Lesson).WithMany(a => a.Attenants).HasForeignKey(a => a.LessonId);

        }
    }
}
