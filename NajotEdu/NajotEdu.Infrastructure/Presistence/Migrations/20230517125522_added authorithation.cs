using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NajotEdu.Infrastructure.Migrations
{
    public partial class addedauthorithation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "PasswordHash", "Role", "UserName" },
                values: new object[] { 1, null, "999BD10B3BC249B5741AB1A662ACC00B225EBEF14E42A684CDDB49EE92DB096E2FFDF047EE79C59C4F6726D375494A5FF82E19288A5680EC4A3136F30C2752F2", 1, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
