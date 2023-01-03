using code.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace code.Data
{
    public class CodeDbContext : DbContext
    {
        public CodeDbContext(DbContextOptions<CodeDbContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
