using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class TrainerDbContext: DbContext
    {
        public DbSet<Trainer> Name { get; set; }
        public DbSet<Trainer> EMail { get; set; }
        public DbSet<Trainer> PhoneNumber { get; set; }
    }
}
