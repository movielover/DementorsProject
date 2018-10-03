using Microsoft.EntityFrameworkCore;

namespace Dementors.Model
{
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkoutSeance> WorkoutSeance { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=master;" + "Trusted_Connection=True;");
        }
    }
}
