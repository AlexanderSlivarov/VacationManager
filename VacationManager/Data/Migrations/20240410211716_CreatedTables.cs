using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationManager.Data.Migrations
{
    public partial class CreatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HalfDay = table.Column<bool>(type: "bit", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ApplicantId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_AspNetUsers_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    LeaderID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_AspNetUsers_LeaderID",
                        column: x => x.LeaderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    { 1, "18cfd965-a67f-4a29-833e-72adb21194b3", true, new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9241), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true },
                    { 2, "18cfd965-a67f-4a29-833e-72adb21194b3", true, new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9280), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true },
                    { 3, "18cfd965-a67f-4a29-833e-72adb21194b3", true, new DateTime(2024, 4, 11, 0, 17, 16, 152, DateTimeKind.Local).AddTicks(9283), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), true }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeaderID", "ProjectId" },
                values: new object[,]
                {
                    { 1, "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306", 1 },
                    { 2, "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306", 2 },
                    { 3, "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306", 2 },
                    { 4, "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_ApplicantId",
                table: "Leaves",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderID",
                table: "Teams",
                column: "LeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3085f016-1a6e-4bce-8729-10b4d0aabbe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68c66bd7-ade8-459e-a300-cac5c43f2305");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18cfd965-a67f-4a29-833e-72adb21194b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2339cd21-3fe5-4cf4-a6c2-74ee2ae1b306");

            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
