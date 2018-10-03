using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class WorkoutSeance
    {
        private string _key;

        public string key
        {
            get
            {
                
            }
            set
            {
                key
            }
        }
        
        [Required]
        public int TimeSpent { get; set; }
        public DateTime TimeDateForWorkout { get; set; }
        [Required]
        public string WorkoutType { get; set; }
        public long UserId { get; set; }
    }
}
