using Microsoft.EntityFrameworkCore;

namespace Dementors.Model
{
    public class WorkoutSeanceDbContext : DbContext
    {
        public DbSet<WorkoutSeance> TimeSpent { get; set; }
        public DbSet<WorkoutSeance> TimeDateForWorkout { get; set; }
        public DbSet<WorkoutSeance> WorkoutType { get; set; }
        public DbSet<WorkoutSeance> UserId { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=den1.mssql2.gear.host; Database=dementor;User Id=dementor;
            Password = Jr5ZlkG-8ti-;");
        }
    }
}
