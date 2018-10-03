﻿using Microsoft.EntityFrameworkCore;

namespace Dementors.Models
{
    public class DatabaseContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkoutSeance> WorkoutSeance { get; set; }

        
    }
}
