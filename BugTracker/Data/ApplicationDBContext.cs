using BugTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
            
        }
        // public DbSet<Ticket> Tickets { get; set; }

        //public DbSet<Project> Projects { get; set; }

    }
}
