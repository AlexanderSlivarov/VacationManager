using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class Dsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
