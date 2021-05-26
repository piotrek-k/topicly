using System;
using System.Linq;
using Data;
using Data.Models.Chats;
using Data.Models.Topics;
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
                if (context.Messages.Any() && context.Topics.Any())
                {
                    // no need to populate db
                    return;
                }
                
                for (int y = 0; y < 10; y++)
                {
                    var topic = context.Topics.Add(new Topic()
                    {
                        Name = "TEMAT #" + (y+1),
                        CreatedBy = "id_of_user_that_created_it"
                    });
                    
                    context.SaveChanges();
                    
                    var chat = context.Chats.Add(new Chat()
                    {
                        TopicId = topic.Entity.Id,
                        TopicAnswerer = "id_of_user_that_joined",
                        TopicCreator = "id_of_user_that_created_it"
                    });

                    context.SaveChanges();

                    for (int x = 0; x < 10; x++)
                    {
                        context.Messages.Add(new Message()
                        {
                            Content = "this is test message #" + x,
                            ChatId = chat.Entity.Id,
                            DateOfSending = DateTimeOffset.Now
                        });
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}