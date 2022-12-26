using Microsoft.EntityFrameworkCore;

namespace GQLPractice.GraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}