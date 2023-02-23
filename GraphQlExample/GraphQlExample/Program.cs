using GraphQlExample.Database;
using GraphQlExample.EntityFramework;
using GraphQlExample.GraphQl;
using GraphQlExample.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

            //builder.Services.AddScoped<Repository>().AddAuthentication().Services.AddAuthorization(
            //    o=>o.AddPolicy("Librarian",p=>p.RequireAssertion(_ =>false))).
            //    AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>().
            //    AddAuthorization().
            //    UseField<ExceptionMiddleware>();

            builder.Services.AddScoped<Repository>();
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                var Key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]);
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = builder.Configuration["JWT:Issuer"],//Validate the server that generates the token
                    ValidAudience = builder.Configuration["JWT:Audience"],//Validate the recipient of the tpken is authorized to recive
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                };
            });
            builder.Services.
              AddAuthorization(
             o=>o.AddPolicy("Librarian",p=>p.RequireAssertion(_ =>false))).AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>().
              AddAuthorization().
              UseField<ExceptionMiddleware>();

            var app = builder.Build();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.Map("/", () => "Hi I am Vikash");
            app.MapGraphQL();
            app.Run();
        }
    }
}