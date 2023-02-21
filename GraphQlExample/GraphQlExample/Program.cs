using GraphQlExample.Database;
using GraphQlExample.EntityFramework;
using GraphQlExample.GraphQl;
using GraphQlExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

            //added to inject the configuration settings
            builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("JWT"));
            
            builder.Services.AddScoped<Repository>().AddAuthentication().Services.AddAuthorization(
                o=>o.AddPolicy("Librarian",p=>p.RequireAssertion(_ =>false))).
                AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>().
                AddAuthorization().
                UseField<ExceptionMiddleware>();
            
            var app = builder.Build();
            //app.Map("/", () => "Hi I am Vikash");
            app.MapGraphQL();
            app.Run();
        }
    }
}