using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class GroupEntityTupeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasOne(a => a.Teacher).WithMany(a => a.Groups).HasForeignKey(a => a.TeacherId);
        }
    }
}
