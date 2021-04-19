using Microsoft.EntityFrameworkCore;
using Topicly.Data.Models.Chat;
using Topicly.Data.Models.Topics;
using Topicly.ViewModels;

namespace Topicly.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        
        public DbSet<Topic> Topics { get; set; }
    }
}