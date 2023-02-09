namespace GraphQlExample.Models
{
    public class Book
    {
        public Book() { }
        public Book(Guid _id,string _title,Author _author)
        {
            this.Id = _id;
            this.Title = _title;
            this.author = _author;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }

        public Author author { get; set; }
    }

}
