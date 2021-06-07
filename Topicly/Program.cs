using System;
using System.Threading;
using Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Topicly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<Program>>();

                do
                {
                    try
                    {
                        var context = services.GetRequiredService<ApplicationDbContext>();
                        logger.LogInformation("Ensuring database is set up...");
                        context.Database.EnsureCreated();

                        break;
                    }
                    catch (Exception ex)
                    {
                        logger.LogError("An error occurred creating the DB. Waiting 2 seconds until next " +
                                            "attempt");
                        logger.LogInformation($"Current db config: {Environment.GetEnvironmentVariable("DB_CONFIG")}");
                        Thread.Sleep(2000);
                    }
                } while (true);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}