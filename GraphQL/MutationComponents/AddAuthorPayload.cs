using GQLPractice.GraphQL.Data;

namespace GraphQL.Mutations
{
    public class AddAuthorPayload
    {
        public AddAuthorPayload(Author author)
        {
            Author = author;
        }

        public Author Author { get; }
    }
}
