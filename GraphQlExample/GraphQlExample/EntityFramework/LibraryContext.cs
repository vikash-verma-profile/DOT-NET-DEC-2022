using GraphQlExample.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlExample.EntityFramework
{
    public class LibraryContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions options):base(options)
        {

        }
    }
}
