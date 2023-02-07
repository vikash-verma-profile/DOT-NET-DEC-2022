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

        public async Task<BookPayload> AddBook(BookInput input, [Service] Repository repository)
        {

            var author = await repository.GetAuthor(input.Author);
            var book = new Book(Guid.NewGuid(), input.Title,author);
            await repository.AddBook(book);
            return new BookPayload(book);
        }
    }
}
public record AuthorInput(string Name);
public record BookInput(string Title,Guid Author);

public record AuthorPayload(Author? Record,string?Error=null):Payload(Error);
public record BookPayload(Book? Record, string? Error = null) : Payload(Error);

public record Payload(string? Error);
