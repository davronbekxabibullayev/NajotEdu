using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Infrastructure.Presistence.EntityTupeConfiguration
{
    public class UserTypeCofiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(a => a.UserName).IsUnique();
            builder.Property(a => a.UserName).HasMaxLength(30);

            builder.HasData(new User()
            {
                Id = 1,
                UserName = "Admin",
                Role = Domain.Enum.UserRole.Admin,
                FullName = "Adminbek Adminov",
                PasswordHash = "442975CD735175F7C42F91322F548F7C4A606B838A992381F3C9AB48A85576C1C1864E625A1A00A2D16359395B8321E52BF4DFFB6347341141633E07C197D3D8NajotTalimQalampir"
                // PasswordHash == fff
            });

        }
    }
}
