using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class StudentTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(a => a.PhoneNumber).HasMaxLength(15);
            builder.Property(a => a.FullName).HasMaxLength(100).IsRequired();

        }
    }
}
