using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class xd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "568fdf1d-3fa8-4167-b313-c43d3095cac3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd46d6ab-0297-43b9-8a4f-04b9ab3bc264", 0, "d2e000e6-5365-4492-af01-8f6084b02d70", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEISn3bRNRs4iXq1m5Im4GQe3JNX9jalj2JCMaYpYu6mhX5klJE/1/uzu8ByWrsGirQ==", null, false, "CEO", "dd12880e-2f6d-44fb-8081-b26b28fb9919", "CEO's", false, "ce@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd46d6ab-0297-43b9-8a4f-04b9ab3bc264");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "568fdf1d-3fa8-4167-b313-c43d3095cac3", 0, "2ffeada1-09d7-402c-86ee-8a58569264f8", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEIcMiWOuVYlQG+d5QYU5CxMmuD9vJMMSlJwu+g6gWIcQcD+pLMiQAYTNAOSw0+l82w==", null, false, "CEO", "1edd449c-27fd-41ab-86ab-e8c262575b08", "CEO's", false, "ceo@gmail.com" });
        }
    }
}
