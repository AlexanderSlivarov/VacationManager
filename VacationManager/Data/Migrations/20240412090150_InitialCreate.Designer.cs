﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacationManager.Data;

#nullable disable

namespace VacationManager.Data.Migrations
{
    [DbContext(typeof(VacationManagerDbContext))]
    [Migration("20240412090150_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VacationManager.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "43edd877-19b0-474e-a1ea-4cd56dbdb0c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0fc9ab8d-c8f9-4a9c-b1d9-b7ece76ff368",
                            EmailConfirmed = false,
                            FirstName = "Sasho",
                            LastName = "Manekena",
                            LockoutEnabled = false,
                            NormalizedUserName = "CEO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDCwbpMZ3ORv3/1HoAPSm0cZR0l+LIqYVbYQf04B2oIQKeuq1z615O3xBfCJ55URDQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8c7dc5c5-7b6d-4f85-81e8-60f125721d9a",
                            TeamName = "ceotata",
                            TwoFactorEnabled = false,
                            UserName = "ceo@gmail.com"
                        },
                        new
                        {
                            Id = "8a49aeaa-f3c0-4d82-ab55-eb6c7c250d03",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a69d549-91a7-45a9-babc-9b5512a58641",
                            EmailConfirmed = false,
                            FirstName = "Marin",
                            LastName = "Pingvin",
                            LockoutEnabled = false,
                            NormalizedUserName = "DEVELOPER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELI5ht2UAadzoK1DHlwiBEEl/Zdfl/rrLTStttOmessV4ieuoX8JZ7KeHvjA0A2KuQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1c343a7-ff88-46d7-8e04-46d5d58f6c44",
                            TeamName = "Developerite",
                            TwoFactorEnabled = false,
                            UserName = "developer@gmail.com"
                        },
                        new
                        {
                            Id = "c7d4efd3-6dcc-4fde-a462-372e8cb03702",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4190a594-18d7-4e90-9c80-5a2c50ea3f1b",
                            EmailConfirmed = false,
                            FirstName = "Steven",
                            LastName = "Rodgrigez",
                            LockoutEnabled = false,
                            NormalizedUserName = "TEAMLEAD@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOydT2M1LkrpQk5qHhim6f+HvflcGzpfh1vRNiPL4HOh65lE3JmcslIpAC2iCpWd2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a0561a61-4717-4567-a6fa-913012186f56",
                            TeamName = "Leaderite",
                            TwoFactorEnabled = false,
                            UserName = "teamlead@gmail.com"
                        },
                        new
                        {
                            Id = "bfc26b82-f9e6-4b3d-8648-afaaa9040289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7ebb24c-586f-482a-9db6-5ad0ed113891",
                            EmailConfirmed = false,
                            FirstName = "Jordan",
                            LastName = "Fugata",
                            LockoutEnabled = false,
                            NormalizedUserName = "UNASSIGNED@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBRxnp0uATqPgS2BoblM2ehrnHiijK1dtNza4egFt54Va4gk+0q+zdSreae0Vl39PA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "898d12b1-2bd2-4eb3-88df-d446c698278f",
                            TeamName = "Randomite",
                            TwoFactorEnabled = false,
                            UserName = "unassigned@gmail.com"
                        });
                });

            modelBuilder.Entity("VacationManager.Data.Models.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HalfDay")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Leaves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicantId = "bfc26b82-f9e6-4b3d-8648-afaaa9040289",
                            Approved = true,
                            CreationDate = new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2236),
                            DateFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                            HalfDay = true
                        },
                        new
                        {
                            Id = 2,
                            ApplicantId = "bfc26b82-f9e6-4b3d-8648-afaaa9040289",
                            Approved = true,
                            CreationDate = new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2277),
                            DateFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                            HalfDay = true
                        },
                        new
                        {
                            Id = 3,
                            ApplicantId = "bfc26b82-f9e6-4b3d-8648-afaaa9040289",
                            Approved = true,
                            CreationDate = new DateTime(2024, 4, 12, 12, 1, 49, 913, DateTimeKind.Local).AddTicks(2280),
                            DateFrom = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateTo = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                            HalfDay = true
                        });
                });

            modelBuilder.Entity("VacationManager.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "purviproekt",
                            Name = "ProektEdno"
                        },
                        new
                        {
                            Id = 2,
                            Description = "vtoriproekt",
                            Name = "ProektDve"
                        },
                        new
                        {
                            Id = 3,
                            Description = "tretiproekt",
                            Name = "ProektTri"
                        });
                });

            modelBuilder.Entity("VacationManager.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LeaderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaderID");

                    b.HasIndex("ProjectId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LeaderID = "c7d4efd3-6dcc-4fde-a462-372e8cb03702",
                            Name = "OtborEdno",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            LeaderID = "c7d4efd3-6dcc-4fde-a462-372e8cb03702",
                            Name = "OtborDve",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            LeaderID = "c7d4efd3-6dcc-4fde-a462-372e8cb03702",
                            Name = "OtborTri",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 4,
                            LeaderID = "c7d4efd3-6dcc-4fde-a462-372e8cb03702",
                            Name = "OtborChetiri",
                            ProjectId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("VacationManager.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VacationManager.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManager.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VacationManager.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VacationManager.Data.Models.Leave", b =>
                {
                    b.HasOne("VacationManager.Data.ApplicationUser", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");
                });

            modelBuilder.Entity("VacationManager.Data.Models.Team", b =>
                {
                    b.HasOne("VacationManager.Data.ApplicationUser", "Leader")
                        .WithMany()
                        .HasForeignKey("LeaderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationManager.Data.Models.Project", "Project")
                        .WithMany("Teams")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Leader");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("VacationManager.Data.Models.Project", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
