using GraphQlExample.Database;
using GraphQlExample.Models;

namespace GraphQlExample.GraphQl
{
    public class Query
    {
        //public string Hello()=>"Hello";
        public Task<List<Book>> GetBooks([Service]Repository repository)=>repository.GetBooksAsync();
        public Task<List<Author>> GetAuthors([Service] Repository repository) => repository.GetAuthorsAsync();
    }
}
