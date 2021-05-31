using Data.Models.Algorithm;
using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;

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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IOptions<OperationalStoreOptions> operationalStoreOptions)
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
    }
}