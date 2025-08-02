
using Lineage2DataBase.Api;

namespace Lineage2DataBase
{
    /// <summary>
    /// The entry point of the application.
    /// </summary>
    /// <remarks>This class configures and starts the web application. It sets up services, middleware, and
    /// routing for the application. The application is built using the ASP.NET Core framework.</remarks>
    public class Program
    {/// <summary>
     /// The main method that serves as the entry point for the application.
     /// </summary> 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

            builder.Services.AddSwaggerGen();
            builder.Services.AddLineage2DataBaseApi();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
