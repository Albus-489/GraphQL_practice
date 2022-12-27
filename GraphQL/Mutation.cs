using GQLPractice.GraphQL.Data;
using GraphQL.Mutations;
using HotChocolate;

namespace GQLPractice.GraphQL
{
    public class Mutation
    {
        public async Task<AddAuthorPayload> AddAuthorAsync(
            AddAuthorInput input,
            [Service] AppDbContext context)
        {
            var speaker = new Author
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Authors.Add(speaker);
            await context.SaveChangesAsync();

            return new AddAuthorPayload(speaker);
        }
    }
}
