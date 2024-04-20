using BugTracker.Models;
using BugTracker.Utility;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
            
        }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Project> Projects { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Manhatan P", Description = "Produce nuclear weapons" }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, Description="How to split atom", ProjectId=1, Title="Atom splitting", Priority=SD.priority_medium, Status = SD.status_new, CreatedOn=DateTime.Now }
            );
        }
    }
}
