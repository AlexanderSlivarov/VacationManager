using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class HAHAHA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd72fe53-7ac3-4220-9d2b-8a184521e4d9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18af0cf3-d4e7-440a-9759-e0b9126c3a38", 0, "d7df73a0-3d52-4254-b481-2747a068a0d2", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEAX216xHQEeYAL6QYsxSQukbfsfAdIJfOeXtNM0P6qnv4pKboVK/3sTBWv1JNfxmIQ==", null, false, "CEO", "453ce2b5-bf74-456d-81f7-c07c8446e536", "CEO's", false, "ceo@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18af0cf3-d4e7-440a-9759-e0b9126c3a38");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd72fe53-7ac3-4220-9d2b-8a184521e4d9", 0, "ae356120-858d-4be7-8ed4-b2ca84bb3ceb", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEBH6gwQR/eiCsFUxlDq6XIwQ6LE6wt1C9xpwu30KfIN9jzVzRT+KmSzPxF81t/6pRw==", null, false, "CEO", "851b6279-ae81-433b-8ee5-41b672ab7751", "CEO's", false, "ceo@gmail.com" });
        }
    }
}
