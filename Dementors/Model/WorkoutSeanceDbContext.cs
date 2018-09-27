using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class WorkoutSeanceDbContext: DbContext
    {
        public DbSet<WorkoutSeance> TimeSpent { get; set; }
        public DbSet<WorkoutSeance> TimeDateForWorkout { get; set; }
        public DbSet<WorkoutSeance> WorkoutType { get; set; }
        public DbSet<WorkoutSeance> UserId { get; set; }
    }
}
