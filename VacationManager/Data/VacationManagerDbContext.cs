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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Team>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Teams)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);            
        }      
    }
}