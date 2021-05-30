using System;
using System.IO;
using System.Reflection;
using System.Text;
using Data;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Topicly.AutoMapper;
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
            string typeOfDbConfig = Environment.GetEnvironmentVariable("DB_CONFIG");
            
            if (typeOfDbConfig != null && typeOfDbConfig == "docker_compose")
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    Configuration.GetSection("DatabaseSettings")["DockerComposeSetup"]));
            }
            else if (typeOfDbConfig != null && typeOfDbConfig == "db_as_container")
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    Configuration.GetSection("DatabaseSettings")["DeployedAsContainer"]));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    Configuration.GetSection("DatabaseSettings")["StandardSetup"]));
            }

            services.AddDefaultIdentity<ApplicationUser>(opt =>
                {
                    var stringBuilder = new StringBuilder();

                    for (char c = 'a'; c != 'z'; ++c) stringBuilder.Append(c);
                    for (char c = 'A'; c != 'Z'; ++c) stringBuilder.Append(c);
                    for (char c = '0'; c != '9'; ++c) stringBuilder.Append(c);
                    stringBuilder.Append("-_");

                    opt.User.AllowedUserNameCharacters =  stringBuilder.ToString();
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.Parse(Configuration["CookiesMinutesTimeSpan"]);
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Topicly", Version = "v1"});
                
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddSignalR();

            services.AddAutoMapper(config => config.AddProfile(new AutoMapperProfile()));
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