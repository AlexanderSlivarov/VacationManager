using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class blq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18af0cf3-d4e7-440a-9759-e0b9126c3a38");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "974bb7c5-7e76-42f9-bef1-636c7900708e", 0, "f56e92be-beae-4e8b-9c66-6a19ae75232d", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEG5FdRoLJEEuKcNG0PsAPciRLwHxkBhaVlM4uhwJLOfMq9tsB49UO+nrz+OEmujzfg==", null, false, "CEO", "d24a690c-c4c4-427e-b78a-806d256a4a0e", "CEO's", false, "ceo@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams",
                column: "LeaderID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974bb7c5-7e76-42f9-bef1-636c7900708e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18af0cf3-d4e7-440a-9759-e0b9126c3a38", 0, "d7df73a0-3d52-4254-b481-2747a068a0d2", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEAX216xHQEeYAL6QYsxSQukbfsfAdIJfOeXtNM0P6qnv4pKboVK/3sTBWv1JNfxmIQ==", null, false, "CEO", "453ce2b5-bf74-456d-81f7-c07c8446e536", "CEO's", false, "ceo@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams",
                column: "LeaderID");
        }
    }
}
