using System;
using System.Globalization;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Topicly.Hubs;

namespace Topicly
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // użycie innego Connection Stringa w zależności od ustawionej zmiennej środowiskowej
            string enableDockerComposeConfig = Environment.GetEnvironmentVariable("dbConfig");

            if (enableDockerComposeConfig != null && enableDockerComposeConfig.ToLower() == "true")
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    Configuration.GetSection("DatabaseSettings")["DockerComposeSetup"]));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    Configuration.GetSection("DatabaseSettings")["DeployedAsContainer"]));
            }

            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.Parse(Configuration["CookiesMinutesTimeSpan"]);
            });

            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Topicly", Version = "v1" }); });
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Topicly v1"));
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}