using GraphQlExample.EntityFramework;
using GraphQlExample.Models;

namespace GraphQlExample.Database
{
    public class Repository
    {
        //List<Author> Authors = new List<Author>();
        //List<Book> Books = new List<Book>();
        LibraryContext db;
        public Repository(LibraryContext _db)
        {
            db = _db;
        }
       
        public Task<List<Book>> GetBooksAsync()
        {
            return Task.FromResult(db.Books.ToList());
        }

        public Task<List<Author>> GetAuthorsAsync()
        {
            return Task.FromResult(db.Authors.ToList());
        }
        public Task<Author?> GetAuthor(Guid authorId)
        {
            return Task.FromResult(db.Authors.FirstOrDefault(a => a.Id == authorId));
        }
        public Task AddAuthor(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
            return Task.CompletedTask;
        }
        public Task AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<Login?> ValidateUser(Login login)
        {
            return Task.FromResult(db.Logins.FirstOrDefault(a => a.Password.ToLower() ==login.Password.ToLower() && a.Email==login.Email ));
        }
    }
}
