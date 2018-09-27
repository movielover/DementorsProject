using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class InformationDbContext: DbContext
    {
        public DbSet<Information> Text { get; set; }
        public DbSet<Information> TimeDate { get; set; }
    }
}
