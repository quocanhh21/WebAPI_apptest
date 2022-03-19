using Microsoft.EntityFrameworkCore;

namespace WebAPI_apptest.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
