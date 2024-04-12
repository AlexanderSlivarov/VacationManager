using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17c8ccc5-9e33-4f37-9bb1-be88bbfb7d6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fdeb990-62d4-41e7-90fc-fa213e9e6109");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55a40151-ee78-40ac-8fc1-79c3e0816ade");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a481ea6a-3ac1-4be7-a131-285be0bfc748");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43edd877-19b0-474e-a1ea-4cd56dbdb0c3", 0, "0fc9ab8d-c8f9-4a9c-b1d9-b7ece76ff368", null, false, "Sasho", "Manekena", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEDCwbpMZ3ORv3/1HoAPSm0cZR0l+LIqYVbYQf04B2oIQKeuq1z615O3xBfCJ55URDQ==", null, false, "8c7dc5c5-7b6d-4f85-81e8-60f125721d9a", "ceotata", false, "ceo@gmail.com" },
                    { "8a49aeaa-f3c0-4d82-ab55-eb6c7c250d03", 0, "8a69d549-91a7-45a9-babc-9b5512a58641", null, false, "Marin", "Pingvin", false, null, null, "DEVELOPER@GMAIL.COM", "AQAAAAEAACcQAAAAELI5ht2UAadzoK1DHlwiBEEl/Zdfl/rrLTStttOmessV4ieuoX8JZ7KeHvjA0A2KuQ==", null, false, "e1c343a7-ff88-46d7-8e04-46d5d58f6c44", "Developerite", false, "developer@gmail.com" },
                    { "bfc26b82-f9e6-4b3d-8648-afaaa9040289", 0, "c7ebb24c-586f-482a-9db6-5ad0ed113891", null, false, "Jordan", "Fugata", false, null, null, "UNASSIGNED@GMAIL.COM", "AQAAAAEAACcQAAAAEBRxnp0uATqPgS2BoblM2ehrnHiijK1dtNza4egFt54Va4gk+0q+zdSreae0Vl39PA==", null, false, "898d12b1-2bd2-4eb3-88df-d446c698278f", "Randomite", false, "unassigned@gmail.com" },
                    { "c7d4efd3-6dcc-4fde-a462-372e8cb03702", 0, "4190a594-18d7-4e90-9c80-5a2c50ea3f1b", null, false, "Steven", "Rodgrigez", false, null, null, "TEAMLEAD@GMAIL.COM", "AQAAAAEAACcQAAAAEOydT2M1LkrpQk5qHhim6f+HvflcGzpfh1vRNiPL4HOh65lE3JmcslIpAC2iCpWd2w==", null, false, "a0561a61-4717-4567-a6fa-913012186f56", "Leaderite", false, "teamlead@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "bfc26b82-f9e6-4b3d-8648-afaaa9040289", new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "bfc26b82-f9e6-4b3d-8648-afaaa9040289", new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "bfc26b82-f9e6-4b3d-8648-afaaa9040289", new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaderID",
                value: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "LeaderID",
                value: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "LeaderID",
                value: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "LeaderID",
                value: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43edd877-19b0-474e-a1ea-4cd56dbdb0c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a49aeaa-f3c0-4d82-ab55-eb6c7c250d03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfc26b82-f9e6-4b3d-8648-afaaa9040289");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17c8ccc5-9e33-4f37-9bb1-be88bbfb7d6b", 0, "07241867-8b46-4f8b-a927-945d9f00cfa1", null, false, "Sasho", "Manekena", false, null, null, "CEO@GMAIL.COM", "AQAAAAEAACcQAAAAEAuEP9t5oooV/ovJt2W/xCpZGHfE3h/hg1C2Gk8XoZL9kUwv6MvYAJ48bb8c4fY8Zw==", null, false, "efda07fd-abdd-4f2a-9b57-86e5d47ddad6", "ceotata", false, "ceo@gmail.com" },
                    { "3fdeb990-62d4-41e7-90fc-fa213e9e6109", 0, "521194cb-8c5f-457c-96e6-fbe0fdd1ccce", null, false, "Jordan", "Fugata", false, null, null, "UNASSIGNED@GMAIL.COM", "AQAAAAEAACcQAAAAEP+bVkS6xF0+oNKxoggi/kBd2704KwdonyMkQvOWJNPHvbvLQe6RcbmkBrbderecNQ==", null, false, "24936082-b377-434b-90ae-6894f50c1b78", "Randomite", false, "unassigned@gmail.com" },
                    { "55a40151-ee78-40ac-8fc1-79c3e0816ade", 0, "f75a10d6-2f65-4c99-b9c9-cf0e1129ba16", null, false, "Marin", "Pingvin", false, null, null, "DEVELOPER@GMAIL.COM", "AQAAAAEAACcQAAAAEICcjzD4MoHJGZqvBK7lkmfoqVGHDNINU6SHhhp7NvUYPkfA4/K2IkFSQkifoiWR/A==", null, false, "b19f5023-beff-4f2a-bdb0-83df5f65da61", "Developerite", false, "developer@gmail.com" },
                    { "a481ea6a-3ac1-4be7-a131-285be0bfc748", 0, "e804073d-f966-4280-ba60-b31f58c111d9", null, false, "Steven", "Rodgrigez", false, null, null, "TEAMLEAD@GMAIL.COM", "AQAAAAEAACcQAAAAEJ/NY3wlVAusI6ODiUjKGU3o3KNy+zB1FipJFQFvqk3wlmrnDB1V/A+J8aZF/ejA8g==", null, false, "866dff19-5805-477a-9094-2e63bbb8b091", "Leaderite", false, "teamlead@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "3fdeb990-62d4-41e7-90fc-fa213e9e6109", new DateTime(2024, 4, 11, 23, 10, 32, 317, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "3fdeb990-62d4-41e7-90fc-fa213e9e6109", new DateTime(2024, 4, 11, 23, 10, 32, 317, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantId", "CreationDate" },
                values: new object[] { "3fdeb990-62d4-41e7-90fc-fa213e9e6109", new DateTime(2024, 4, 11, 23, 10, 32, 317, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaderID",
                value: "a481ea6a-3ac1-4be7-a131-285be0bfc748");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "LeaderID",
                value: "a481ea6a-3ac1-4be7-a131-285be0bfc748");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "LeaderID",
                value: "a481ea6a-3ac1-4be7-a131-285be0bfc748");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "LeaderID",
                value: "a481ea6a-3ac1-4be7-a131-285be0bfc748");
        }
    }
}
