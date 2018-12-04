using Microsoft.EntityFrameworkCore;

namespace Dementors.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Bruger> User { get; set; }
        public DbSet<WorkoutSession> WorkoutSession { get; set; }


        public DatabaseContext(DbContextOptions options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
