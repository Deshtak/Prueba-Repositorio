using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define DbSets para tus modelos. Por ejemplo:
        public DbSet<MyEntity> MyEntities { get; set; }
    }

    // Define un modelo de ejemplo:
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}