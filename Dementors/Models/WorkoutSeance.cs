using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class WorkoutSeance
    {
        public int Id { get; set; }
        public int TimeSpent { get; set; }
        public DateTime TimeDateForWorkout { get; set; }
        public string WorkoutType { get; set; }
        public int UserId { get; set; }
    }
}
