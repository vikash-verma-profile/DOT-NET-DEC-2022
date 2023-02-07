using GraphQlExample.Models;

namespace GraphQlExample.Database
{
    public class Mutation
    {
        public async Task<AuthorPayload> AddAuthor(AuthorInput authorInput, [Service] Repository repository)
        {
            var author = new Author(Guid.NewGuid(), authorInput.Name);
            await repository.AddAuthor(author); 
            return new AuthorPayload(author);
        }
    }
}
public record AuthorInput(string Name);

public record AuthorPayload(Author? Record,string?Error=null):Payload(Error);

public record Payload(string? Error);
