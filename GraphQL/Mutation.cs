using GQLPractice.GraphQL.Data;
using GraphQL.Mutations;
using HotChocolate;

namespace GQLPractice.GraphQL
{
    public class Mutation
    {
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [Service] AppDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
