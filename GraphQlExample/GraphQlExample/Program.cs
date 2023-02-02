using GraphQlExample.GraphQl;

namespace GraphQlExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGraphQLServer().AddQueryType<Query>();
            var app = builder.Build();
            //app.Map("/", () => "Hi I am Vikash");
            app.MapGraphQL();
            app.Run();
        }
    }
}