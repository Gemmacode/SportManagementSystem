using Microsoft.EntityFrameworkCore;
using SportManagementSystem.Model;

namespace SportManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }    
        public DbSet<Team> Teams { get; set; }  
        public DbSet<Player> Player { get; set; }   
        public DbSet<Match> Match { get; set; } 
        public DbSet<MatchResult> MatchResult { get; set; } 
    }
}
