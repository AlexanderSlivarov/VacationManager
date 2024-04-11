using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class Asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18cfd965-a67f-4a29-833e-72adb21194b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3085f016-1a6e-4bce-8729-10b4d0aabbe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68c66bd7-ade8-459e-a300-cac5c43f2305");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35", 0, "adae9d03-e185-48ae-9a7f-192bed472d7f", null, false, "Steven", "Rodgrigez", false, null, null, "TEAMLEAD@GMAIL.COM", null, null, false, "4cc552b1-cb5e-4e5f-a8fa-fb774bf8dd20", "Leaderite", false, "teamlead@gmail.com" },
                    { "b9845226-832e-4792-a735-a610a6358fcd", 0, "4b66d22f-843c-452c-87db-913ba3256231", null, false, "Marin", "Pingvin", false, null, null, "DEVELOPER@GMAIL.COM", null, null, false, "1a95fb9d-982c-4e61-9521-786b8efb931a", "Developerite", false, "developer@gmail.com" },
                    { "d930106b-3079-4290-940b-4c86cd80275d", 0, "d763c120-0210-4b6e-8c0b-ad9b725c3fb1", null, false, "Sasho", "Manekena", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEBpOfKCCB4/WBcByDKRgtbevYyWMfAvV9NYjnxkOuzLpKgjwYqN0kQuj5oAoPWqZSg==", null, false, "cde6e5dc-5190-4546-93f2-be693e497207", "ceotata", false, "ceo@gmail.com" },
                    { "f1c49bf5-70ea-4757-8217-ed085f104bc1", 0, "e981ac8e-403c-4a83-9890-4dc6ce380ac9", null, false, "Jordan", "Fugata", false, null, null, "UNASSIGNED@GMAIL.COM", null, null, false, "8e73c495-f137-4352-840e-a3371b67cac5", "Randomite", false, "unassigned@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "f1c49bf5-70ea-4757-8217-ed085f104bc1", new DateTime(2024, 4, 11, 16, 55, 36, 634, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "f1c49bf5-70ea-4757-8217-ed085f104bc1", new DateTime(2024, 4, 11, 16, 55, 36, 634, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "f1c49bf5-70ea-4757-8217-ed085f104bc1", new DateTime(2024, 4, 11, 16, 55, 36, 634, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LeaderID", "Name" },
                values: new object[] { "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35", "OtborEdno" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LeaderID", "Name" },
                values: new object[] { "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35", "OtborDve" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LeaderID", "Name" },
                values: new object[] { "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35", "OtborTri" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LeaderID", "Name" },
                values: new object[] { "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35", "OtborChetiri" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9845226-832e-4792-a735-a610a6358fcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d930106b-3079-4290-940b-4c86cd80275d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1c49bf5-70ea-4757-8217-ed085f104bc1");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teams");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18cfd965-a67f-4a29-833e-72adb21194b3", 0, "95450f2d-0544-41a5-9c7d-a26223bb7e24", null, false, "Jordan", "Fugata", false, null, null, "UNASSIGNED@GMAIL.COM", null, null, false, "aca11284-8339-4cb4-b65b-c3ab6035b8cc", "Randomite", false, "unassigned@gmail.com" },
                    { "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306", 0, "038d2e60-47ed-43dd-b6da-7c2621ce92e9", null, false, "Steven", "Rodgrigez", false, null, null, "TEAMLEAD@GMAIL.COM", null, null, false, "6f532f03-ff35-4196-99ae-6226097633d8", "Leaderite", false, "teamlead@gmail.com" },
                    { "3085f016-1a6e-4bce-8729-10b4d0aabbe2", 0, "a2a443dd-f1ce-4329-98a7-02f2f7983e8c", null, false, "Marin", "Pingvin", false, null, null, "DEVELOPER@GMAIL.COM", null, null, false, "42a7b217-ef44-4839-a267-227a3105514e", "Developerite", false, "developer@gmail.com" },
                    { "68c66bd7-ade8-459e-a300-cac5c43f2305", 0, "1e5e3ec6-acdb-4845-b19e-60936d8aefa2", null, false, "Sasho", "Manekena", false, null, null, "CEO@GMAIL.COM", null, null, false, "b7ce7da4-a9de-4da0-80d5-da278c7391ed", "ceotata", false, "ceo@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "18cfd965-a67f-4a29-833e-72adb21194b3", new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "18cfd965-a67f-4a29-833e-72adb21194b3", new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "18cfd965-a67f-4a29-833e-72adb21194b3", new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaderID",
                value: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "LeaderID",
                value: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "LeaderID",
                value: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "LeaderID",
                value: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");
        }
    }
}
