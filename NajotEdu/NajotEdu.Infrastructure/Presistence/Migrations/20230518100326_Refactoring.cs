using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NajotEdu.Infrastructure.Migrations
{
    public partial class Refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "PasswordHash" },
                values: new object[] { "Adminbek Adminov", "442975CD735175F7C42F91322F548F7C4A606B838A992381F3C9AB48A85576C1C1864E625A1A00A2D16359395B8321E52BF4DFFB6347341141633E07C197D3D8NajotTalimQalampir" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "PasswordHash" },
                values: new object[] { null, "999BD10B3BC249B5741AB1A662ACC00B225EBEF14E42A684CDDB49EE92DB096E2FFDF047EE79C59C4F6726D375494A5FF82E19288A5680EC4A3136F30C2752F2" });
        }
    }
}
