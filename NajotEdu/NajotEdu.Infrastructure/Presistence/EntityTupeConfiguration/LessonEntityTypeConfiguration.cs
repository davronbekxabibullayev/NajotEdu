using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class LessonEntityTypeConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Group).WithMany(a => a.Lessons).HasForeignKey(a => a.GroupId);
        }
    }
}
