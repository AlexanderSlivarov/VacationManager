using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class kilmme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd46d6ab-0297-43b9-8a4f-04b9ab3bc264");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd72fe53-7ac3-4220-9d2b-8a184521e4d9", 0, "ae356120-858d-4be7-8ed4-b2ca84bb3ceb", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEBH6gwQR/eiCsFUxlDq6XIwQ6LE6wt1C9xpwu30KfIN9jzVzRT+KmSzPxF81t/6pRw==", null, false, "CEO", "851b6279-ae81-433b-8ee5-41b672ab7751", "CEO's", false, "ceo@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd72fe53-7ac3-4220-9d2b-8a184521e4d9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd46d6ab-0297-43b9-8a4f-04b9ab3bc264", 0, "d2e000e6-5365-4492-af01-8f6084b02d70", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEISn3bRNRs4iXq1m5Im4GQe3JNX9jalj2JCMaYpYu6mhX5klJE/1/uzu8ByWrsGirQ==", null, false, "CEO", "dd12880e-2f6d-44fb-8081-b26b28fb9919", "CEO's", false, "ce@gmail.com" });
        }
    }
}
