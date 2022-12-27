namespace GraphQL.Mutations
{
    public record AddAuthorInput(
        string Name,
        string Bio,
        string WebSite
    );
}
