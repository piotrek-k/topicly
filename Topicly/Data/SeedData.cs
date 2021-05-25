using System;
using System.Linq;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Topicly.Data
{
    using IdentityServer4.EntityFramework.Options;
    using Microsoft.Extensions.Options;

    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>(),
                serviceProvider.GetRequiredService<IOptions<OperationalStoreOptions>>()))
            {
                if (context.Messages.Any())
                {
                    // no need to populate db
                    return;
                }

                var chat = context.Chats.Add(new Chat());

                context.SaveChanges();

                context.Messages.Add(new Message()
                {
                    Content = "test",
                    ChatId = chat.Entity.Id,
                    DateOfSending = DateTimeOffset.Now
                });

                context.SaveChanges();
            }
        }
    }
}