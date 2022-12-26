using System.Linq;
using HotChocolate;
using GQLPractice.GraphQL.Data;

namespace GQLPractice.GraphQL
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] AppDbContext context) =>
            context.Speakers;
    }
}