using GraphQlExample.Database;
using GraphQlExample.EntityFramework;
using GraphQlExample.GraphQl;
using Microsoft.EntityFrameworkCore;

namespace GraphQlExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection"));
            });
            builder.Services.AddScoped<Repository>().
                AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            var app = builder.Build();
            //app.Map("/", () => "Hi I am Vikash");
            app.MapGraphQL();
            app.Run();
        }
    }
}