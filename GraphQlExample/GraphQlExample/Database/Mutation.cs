using GraphQlExample.Models;
using HotChocolate.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace GraphQlExample.Database
{
    public class Mutation
    {
        [Authorize(Policy= "Librarian")]
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

        public string UserLogin(LoginInput login, [Service] Repository repository, [Service] IOptions<TokenSettings> tokensettings)
        {
            var currentUser = repository.ValidateUser(new Login() { Email=login.Email,Password=login.Password});
            if (currentUser != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokensettings.Value.Key));
                var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

                var jwtToken = new JwtSecurityToken(issuer: tokensettings.Value.Issuer,
                    audience: tokensettings.Value.Audience,
                    expires: DateTime.Now.AddMinutes(20),
                    signingCredentials:credentials) ;

                return new JwtSecurityTokenHandler().WriteToken(jwtToken);
            }

            return "";
        }
    }
}
public record AuthorInput(string Name);
public record BookInput(string Title,Guid Author);

public record AuthorPayload(Author? Record,string?Error=null):Payload(Error);
public record BookPayload(Book? Record, string? Error = null) : Payload(Error);

public record Payload(string? Error);

public record LoginInput(string Email, string Password,string? Error = null) :Payload(Error);
