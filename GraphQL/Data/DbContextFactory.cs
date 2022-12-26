using GQLPractice.GraphQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GQLPractice.GraphQL.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlite("Data Source=graphql_practice.db");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
