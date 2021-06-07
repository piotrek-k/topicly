using System;
using Data.Models.Algorithm;
using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;
using IdentityServer4.Models;

namespace Data
{
    using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using IdentityServer4.EntityFramework.Entities;
    using IdentityServer4.EntityFramework.Options;

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserReaction> Reactions { get; set; }
        public DbSet<SeenByUser> SeenByUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Topicly");
            SetupAspNetIdentityTables(modelBuilder);
            
            SeedUsers(modelBuilder);
            SeedData(modelBuilder);
        }

        private void SeedUsers(ModelBuilder builder)
        {
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                    Email = "bob@mail.com",
                    NormalizedEmail =  "bob@mail.com".ToUpper(),
                    UserName = "bob",
                    NormalizedUserName = "bob".ToUpper()
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHasher.HashPassword(user, "Password1!");

                builder.Entity<ApplicationUser>().HasData(user);
            }
            
            {
                var user = new ApplicationUser()
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    Email = "alice@mail.com",
                    NormalizedEmail =  "alice@mail.com".ToUpper(),
                    UserName = "alice",
                    NormalizedUserName = "alice".ToUpper()
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHasher.HashPassword(user, "Password1!");

                builder.Entity<ApplicationUser>().HasData(user);
            }
        }

        private void SeedData(ModelBuilder builder)
        {
            var dbUser1 = "fab4fac1-c546-41de-aebc-a14da6895711";
            var dbUser2 = "c7b013f0-5201-4317-abd8-c211f91b7330";
            
            Random r = new Random();
            for (int y = -1; y >= -10; y--)
            {
                builder.Entity<Topic>().HasData(new Topic()
                {
                    Id = y,
                    Name = "TEMAT #" + (y + 1),
                    CreatedBy = y % 2 == 0 ? dbUser1 : dbUser2,
                    Tags = "tag" + r.Next(4)
                });

                builder.Entity<Chat>().HasData(new Chat()
                {
                    Id = y,
                    TopicId = y,
                    TopicAnswerer = y % 2 == 0 ? dbUser1 : dbUser2,
                    TopicCreator = y % 2 == 0 ? dbUser2 : dbUser1
                });
            
                for (int x = -1; x >= -10; x--)
                {
                    builder.Entity<Message>().HasData(new Message()
                    {
                        Id = x + (y * 10),
                        Content = "this is test message #" + x,
                        ChatId = y,
                        DateOfSending = DateTimeOffset.Now,
                        SenderId = x % 2 == 0 ? dbUser1 : dbUser2
                    });
                }
            }
        }

        private void SetupAspNetIdentityTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityRole>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityRoleClaim<string>>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityUserClaim<string>>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityUserLogin<string>>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityUserRole<string>>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<IdentityUserToken<string>>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<DeviceFlowCodes>().Metadata.SetSchema("Identity");
            modelBuilder.Entity<PersistedGrant>().Metadata.SetSchema("Identity");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}