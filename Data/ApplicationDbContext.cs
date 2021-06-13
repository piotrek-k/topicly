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
                    NormalizedUserName = "bob".ToUpper(),
                    ConcurrencyStamp = "5b39e64d-1f37-4273-a14b-cf96c621f2be",
                    PasswordHash = "AQAAAAEAACcQAAAAEC9DL7FDwapRt+dT3rP9ABeXLOFipwhUv5WPGKJYnTdoFduEHsy7I2ajVH2ynTOHuA==",
                    SecurityStamp = "1e7c8add-25c2-4666-8c20-88f02ff06fb6",
                };

                builder.Entity<ApplicationUser>().HasData(user);
            }
            
            {
                var user = new ApplicationUser()
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    Email = "alice@mail.com",
                    NormalizedEmail =  "alice@mail.com".ToUpper(),
                    UserName = "alice",
                    NormalizedUserName = "alice".ToUpper(),
                    ConcurrencyStamp = "6d4d777c-833a-4882-8cc2-998741d682fb",
                    PasswordHash = "AQAAAAEAACcQAAAAEJeED9Tjrh1HWd495eES4NMzrLOZNG3whkLCv1YrYwCYXTJRaXOCUq7xEcxKW2AE+A==",
                    SecurityStamp = "c8055658-8a3e-4321-9cf7-6b2e7d52de74",
                };

                builder.Entity<ApplicationUser>().HasData(user);
            }
        }

        private void SeedData(ModelBuilder builder)
        {
            var dbUser1 = "fab4fac1-c546-41de-aebc-a14da6895711";
            var dbUser2 = "c7b013f0-5201-4317-abd8-c211f91b7330";
            
            for (int y = -1; y >= -10; y--)
            {
                builder.Entity<Topic>().HasData(new Topic()
                {
                    Id = y,
                    Name = "TEMAT #" + (y + 1),
                    CreatedById = y % 2 == 0 ? dbUser1 : dbUser2,
                    CreatedAt = new DateTimeOffset(2021, 03, 31, 0, 0, 0, TimeSpan.Zero),
                    Tags = "tag" + (y % 4)
                });

                builder.Entity<Chat>().HasData(new Chat()
                {
                    Id = y,
                    TopicId = y,
                    TopicAnswererId = y % 2 == 0 ? dbUser1 : dbUser2,
                    TopicCreatorId = y % 2 == 0 ? dbUser2 : dbUser1,
                    CreatedAt = new DateTimeOffset(2021, 06, 1, 0, 0, 0, TimeSpan.Zero),
                    LastActivity = new DateTimeOffset(2021, 06, 1, 0, 0, 0, TimeSpan.Zero),
                });
            
                for (int x = -1; x >= -10; x--)
                {
                    builder.Entity<Message>().HasData(new Message()
                    {
                        Id = x + (y * 10),
                        Content = "this is test message #" + x,
                        ChatId = y,
                        DateOfSending = new DateTimeOffset(2021, 06, 1, 0, 0, 0, TimeSpan.Zero),
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