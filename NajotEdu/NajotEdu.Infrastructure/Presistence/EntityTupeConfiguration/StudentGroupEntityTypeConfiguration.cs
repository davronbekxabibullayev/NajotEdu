using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class StudentGroupEntityTypeConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Student).WithMany(a => a.Groups).HasForeignKey(a => a.StudentId);

            builder.HasOne(a => a.Group).WithMany(a => a.GroupStudents).HasForeignKey(a => a.GroupId);
        }
    }
}
