using GraphQlExample.Database;
using GraphQlExample.GraphQl;

namespace GraphQlExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<Repository>().
                AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            var app = builder.Build();
            //app.Map("/", () => "Hi I am Vikash");
            app.MapGraphQL();
            app.Run();
        }
    }
}