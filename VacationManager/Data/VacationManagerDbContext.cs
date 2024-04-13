using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacationManager.Data.Models;

namespace VacationManager.Data
{  
    public class VacationManagerDbContext : IdentityDbContext<ApplicationUser>
    {        
        public VacationManagerDbContext(DbContextOptions<VacationManagerDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        private ApplicationUser CEO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Team>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Teams)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            SeedAdmin();
            modelBuilder
                .Entity<ApplicationUser>()
                .HasData(CEO);

            base.OnModelCreating(modelBuilder);            
        }      

        private void SeedAdmin()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            CEO = new ApplicationUser()
            {
                FirstName = "CEO",
                LastName = "ceo",              
                UserName = "ceo@gmail.com",
                NormalizedUserName = "CEO@GMAIL.COM",
                Role = "CEO"
            };

            CEO.PasswordHash = hasher.HashPassword(CEO, "10ggKK@@");
        }
    }
}