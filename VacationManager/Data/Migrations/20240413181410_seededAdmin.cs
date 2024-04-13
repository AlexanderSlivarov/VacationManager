using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class seededAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "568fdf1d-3fa8-4167-b313-c43d3095cac3", 0, "2ffeada1-09d7-402c-86ee-8a58569264f8", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL>COM", "AQAAAAEAACcQAAAAEIcMiWOuVYlQG+d5QYU5CxMmuD9vJMMSlJwu+g6gWIcQcD+pLMiQAYTNAOSw0+l82w==", null, false, "CEO", "1edd449c-27fd-41ab-86ab-e8c262575b08", "CEO's", false, "ceo@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "568fdf1d-3fa8-4167-b313-c43d3095cac3");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");
        }
    }
}
