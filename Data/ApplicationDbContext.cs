using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        public DbSet<ChatParticipant> ChatsParticipants { get; set; }
        public DbSet<TopicCandidate> TopicsCandidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Topicly");
            SetupAspNetIdentityTables(modelBuilder);

            modelBuilder.Entity<ChatParticipant>(SetupChatParticipants);
            modelBuilder.Entity<TopicCandidate>(SetupTopicCandidates);
            modelBuilder.Entity<Message>(SetupMessages);
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

        private void SetupChatParticipants(EntityTypeBuilder<ChatParticipant> chatParticipant)
        {
            chatParticipant.HasKey(cp => new { cp.ChatId, cp.UserId });

            chatParticipant
                .HasOne(cp => cp.Chat)
                .WithMany(c => c.ChatParticipants)
                .HasForeignKey(cp => cp.ChatId);

            chatParticipant
                .HasOne(cp => cp.User)
                .WithMany(u => u.ChatsParticipant)
                .HasForeignKey(cp => cp.UserId);
        }

        private void SetupTopicCandidates(EntityTypeBuilder<TopicCandidate> topicCandidate)
        {
            topicCandidate.HasKey(tc => new { tc.TopicId, tc.UserId });

            topicCandidate
                .HasOne(tc => tc.Topic)
                .WithMany(t => t.TopicCandidates)
                .HasForeignKey(fk => fk.TopicId);
            topicCandidate
                .HasOne(tc => tc.User)
                .WithMany(u => u.TopicsCandidate)
                .HasForeignKey(tc => tc.UserId);
        }

        private void SetupMessages(EntityTypeBuilder<Message> message)
        {
            message.HasKey(m => new { m.ChatId });
            message.Property(m => m.Id).UseIdentityColumn();

            message
                .HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId);
            message
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.UserId);
        }
    }
}