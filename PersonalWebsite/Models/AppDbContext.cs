using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
           DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Riddle> Riddles { get; set; }
    }
}
