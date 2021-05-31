using System.Collections.Generic;
using Data.Models.Chats;
using Data.Models.Topics;
using Microsoft.AspNetCore.Identity;

namespace Data.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        public List<ChatParticipant> ChatsParticipant { get; set; }
        public List<TopicCandidate> TopicsCandidate { get; set; }
        public List<Message> Messages { get; set; }
    }
}
