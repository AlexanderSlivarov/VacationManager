using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class Asd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2aa3379f-f6e8-4846-8d3b-de6a3fd59a4c", 0, "ec398dae-e42a-45a1-a822-9db0ee150fd4", null, false, "Marin", "Pingvin", false, null, null, "DEVELOPER@GMAIL.COM", "AQAAAAEAACcQAAAAEJqlKh4rr0ANbxvoBCC22IVrOVmqEuq5Wh0QaDvmM2tjTBwtAfXcVnHtKKJ2v9bE2A==", null, false, "1d361de0-1ab6-46fe-b25d-c77217b1b892", "Developerite", false, "developer@gmail.com" },
                    { "2cd61097-4e5b-421e-8ab5-7d2bf104b113", 0, "5a0cac6f-cc73-4abf-9169-b4dbda404527", null, false, "Sasho", "Manekena", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAELw8IZ3tR/QM2K1XYH55CxbTBU3V9pBv3GceiWKXY6KulAX3jRzLyCYgP865XQRoqw==", null, false, "eeaf02eb-78bb-4012-85d3-9088c8ccfb34", "ceotata", false, "ceo@gmail.com" },
                    { "bfdc4eb9-0b0e-4149-abe1-a1522e009617", 0, "a97c85ce-fbcc-4a03-b36d-9c5f22427b10", null, false, "Steven", "Rodgrigez", false, null, null, "TEAMLEAD@GMAIL.COM", "AQAAAAEAACcQAAAAEFOngpJDXQPKy9T4S0yiymcO9JmLlA13+8EJ59znfLyqOh1G/RskwWgGEAtPlIYRTg==", null, false, "331b76e0-2b1f-4b74-b1ee-4fdf8c031e8a", "Leaderite", false, "teamlead@gmail.com" },
                    { "d2ccce78-3fc4-466b-9abc-95f83c5a1725", 0, "f3164e60-3b22-4c5b-8cbc-579584511911", null, false, "Jordan", "Fugata", false, null, null, "UNASSIGNED@GMAIL.COM", "AQAAAAEAACcQAAAAEJo07gSpyQ5EmQ6OWtut94QevD0CVCyCzDByD7GekI2MQTFQ5RO0N0iHNnw24Rh3oQ==", null, false, "6289a614-1a9c-4aa5-934f-0dad53bdf467", "Randomite", false, "unassigned@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "d2ccce78-3fc4-466b-9abc-95f83c5a1725", new DateTime(2024, 4, 11, 16, 59, 49, 59, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "d2ccce78-3fc4-466b-9abc-95f83c5a1725", new DateTime(2024, 4, 11, 16, 59, 49, 59, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "d2ccce78-3fc4-466b-9abc-95f83c5a1725", new DateTime(2024, 4, 11, 16, 59, 49, 59, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaderID",
                value: "bfdc4eb9-0b0e-4149-abe1-a1522e009617");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "LeaderID",
                value: "bfdc4eb9-0b0e-4149-abe1-a1522e009617");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "LeaderID",
                value: "bfdc4eb9-0b0e-4149-abe1-a1522e009617");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "LeaderID",
                value: "bfdc4eb9-0b0e-4149-abe1-a1522e009617");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa3379f-f6e8-4846-8d3b-de6a3fd59a4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cd61097-4e5b-421e-8ab5-7d2bf104b113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfdc4eb9-0b0e-4149-abe1-a1522e009617");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2ccce78-3fc4-466b-9abc-95f83c5a1725");

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
                column: "LeaderID",
                value: "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "LeaderID",
                value: "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "LeaderID",
                value: "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "LeaderID",
                value: "70b396c1-b56d-46fb-9f7a-bcd7e7a7ed35");
        }
    }
}
