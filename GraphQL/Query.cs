using System.Linq;
using HotChocolate;
using GQLPractice.GraphQL.Data;

namespace GQLPractice.GraphQL
{
    public class Query
    {
        public IQueryable<Author> GetAuthors([Service] AppDbContext context) =>
            context.Authors;
    }
}