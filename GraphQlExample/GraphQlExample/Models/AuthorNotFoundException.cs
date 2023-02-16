namespace GraphQlExample.Models
{
    public class AuthorNotFoundException:DException
    {
        public AuthorNotFoundException(){}
        public AuthorNotFoundException(string? message):base(message) { }
        public AuthorNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }

}

    public class DException : Exception
    {
        public DException() { }
        public DException(string? message):base(message) { }
        public DException(string? message,Exception? innerException):base(message, innerException) { }
    }
}
