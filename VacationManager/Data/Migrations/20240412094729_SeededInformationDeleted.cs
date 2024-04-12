using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class SeededInformationDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfc26b82-f9e6-4b3d-8648-afaaa9040289");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7d4efd3-6dcc-4fde-a462-372e8cb03702");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "purviproekt", "ProektEdno" },
                    { 2, "vtoriproekt", "ProektDve" },
                    { 3, "tretiproekt", "ProektTri" }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "ApplicantId", "Approved", "CreationDate", "DateFrom", "DateTo", "HalfDay" },
                values: new object[,]
                {
                    { 1, "bfc26b82-f9e6-4b3d-8648-afaaa9040289", true, new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2236), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true },
                    { 2, "bfc26b82-f9e6-4b3d-8648-afaaa9040289", true, new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true },
                    { 3, "bfc26b82-f9e6-4b3d-8648-afaaa9040289", true, new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2280), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeaderID", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, "c7d4efd3-6dcc-4fde-a462-372e8cb03702", "OtborEdno", 1 },
                    { 2, "c7d4efd3-6dcc-4fde-a462-372e8cb03702", "OtborDve", 2 },
                    { 3, "c7d4efd3-6dcc-4fde-a462-372e8cb03702", "OtborTri", 2 },
                    { 4, "c7d4efd3-6dcc-4fde-a462-372e8cb03702", "OtborChetiri", 3 }
                });
        }
    }
}
