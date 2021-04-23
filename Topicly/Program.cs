using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Topicly.Data;

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
                        var context = services.GetRequiredService<ApplicationContext>();
                        logger.LogInformation("Ensuring database is set up...");
                        context.Database.EnsureCreated();

                        break;
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "An error occurred creating the DB. Waiting 2 seconds until next " +
                                            "attempt");
                        Thread.Sleep(2000);
                    }
                } while (true);

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred seeding the DB");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}