using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class FeedBackDbContext: DbContext
    {
        public DbSet<Feedback> UserId { get; set; }
        public DbSet<Feedback> Text { get; set; }
        public DbSet<Feedback> TimeDate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}
