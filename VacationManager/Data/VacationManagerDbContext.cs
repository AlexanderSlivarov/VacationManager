using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacationManager.Data.Models;

namespace VacationManager.Data
{  
    public class VacationManagerDbContext : IdentityDbContext<ApplicationUser>
    {      
        public ApplicationUser CEO { get; set; }
        public ApplicationUser Developer { get; set; }
        public ApplicationUser TeamLead { get; set; }
        public ApplicationUser Unassigned { get; set; }

        public Project Project1 { get; set; }
        public Project Project2 { get; set; }
        public Project Project3 { get; set; }

        public Leave Paid { get; set; }
        public Leave UnPaid { get; set; }
        public Leave Sick { get; set; }

        public VacationManagerDbContext(DbContextOptions<VacationManagerDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Team>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Teams)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            SeedUsers();
            modelBuilder
                .Entity<ApplicationUser>()
                .HasData(CEO, Developer, TeamLead, Unassigned);

            SeedProjects();
            modelBuilder
                .Entity<Project>()
                .HasData(Project1, Project2, Project3);

            SeedLeaves();
            modelBuilder
                .Entity<Leave>()
                .HasData(Paid, UnPaid, Sick);

            modelBuilder
                .Entity<Team>()
                .HasData(new Team()
                {
                    Id = 1,
                    ProjectId = Project1.Id,                   
                    LeaderID = TeamLead.Id
                },
                new Team()
                {
                    Id = 2,
                    ProjectId = Project2.Id,                   
                    LeaderID = TeamLead.Id
                },
                new Team()
                {
                    Id = 3,
                    ProjectId = Project2.Id,                   
                    LeaderID = TeamLead.Id
                },
                new Team()
                {
                    Id = 4,
                    ProjectId = Project3.Id,                  
                    LeaderID = TeamLead.Id
                });
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            CEO = new ApplicationUser()
            {
                FirstName = "Sasho",
                LastName = "Manekena",
                TeamName = "ceotata",
                UserName = "ceo@gmail.com",
                NormalizedUserName = "CEO@GMAIL.COM"
            };

            Developer = new ApplicationUser()
            {
                FirstName = "Marin",
                LastName = "Pingvin",
                TeamName = "Developerite",
                UserName = "developer@gmail.com",
                NormalizedUserName = "DEVELOPER@GMAIL.COM"
            };

            TeamLead = new ApplicationUser()
            {
                FirstName = "Steven",
                LastName = "Rodgrigez",
                TeamName = "Leaderite",
                UserName = "teamlead@gmail.com",
                NormalizedUserName = "TEAMLEAD@GMAIL.COM"
            };

            Unassigned = new ApplicationUser()
            {
                FirstName = "Jordan",
                LastName = "Fugata",
                TeamName = "Randomite",
                UserName = "unassigned@gmail.com",
                NormalizedUserName = "UNASSIGNED@GMAIL.COM"
            };
        }

        private void SeedProjects()
        {
            Project1 = new Project()
            {
                Id = 1,
                Name = "ProektEdno",
                Description = "purviproekt"
            };

            Project2 = new Project()
            {
                Id = 2,
                Name = "ProektDve",
                Description = "vtoriproekt"
            };

            Project3 = new Project()
            {
                Id = 3,
                Name = "ProektTri",
                Description = "tretiproekt"
            };
        }

        private void SeedLeaves()
        {
            Paid = new Leave()
            {
                Id = 1,
                DateFrom = DateTime.MinValue,
                DateTo = DateTime.MaxValue,
                CreationDate = DateTime.Now,
                HalfDay = true,
                Approved = true,
                ApplicantId = Unassigned.Id,
            };
            UnPaid = new Leave()
            {
                Id = 2,
                DateFrom = DateTime.MinValue,
                DateTo = DateTime.MaxValue,
                CreationDate = DateTime.Now,
                HalfDay = true,
                Approved = true,
                ApplicantId = Unassigned.Id,
            };
            Sick = new Leave()
            {
                Id = 3,
                DateFrom = DateTime.MinValue,
                DateTo = DateTime.MaxValue,
                CreationDate = DateTime.Now,
                HalfDay = true,
                Approved = true,
                ApplicantId = Unassigned.Id,
            };
        }
    }
}