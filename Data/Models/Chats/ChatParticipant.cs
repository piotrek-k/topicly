using Data.Models.Users;

namespace Data.Models.Chats
{
    public class ChatParticipant
    {
        public int ChatId { get; set; }
        public string UserId { get; set; }

        public Chat Chat { get; set; }
        public ApplicationUser User { get; set; }
    }
}
