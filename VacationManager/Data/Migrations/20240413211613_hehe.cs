using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class hehe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974bb7c5-7e76-42f9-bef1-636c7900708e");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24249420-f868-4a52-81e0-e980f457edd9", 0, "cb71c83a-99c6-4d6d-b1a2-43c6d723a0c8", null, false, "CEO", "ceo", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEAZvlogCcvPlWBUQKHoQEokQm8huLOVCTZrhER1oucn9Y+KxWnJLRVDaaoPTP80jig==", null, false, "CEO", "a5bb497e-1ecc-4d2f-8ea5-c56279b81467", false, "ceo@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams",
                column: "LeaderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24249420-f868-4a52-81e0-e980f457edd9");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
