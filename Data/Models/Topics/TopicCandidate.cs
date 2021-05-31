using Data.Models.Users;

namespace Data.Models.Topics
{
    public class TopicCandidate
    {
        public int TopicId { get; set; }
        public string UserId { get; set; }

        public Topic Topic { get; set; }
        public ApplicationUser User { get; set; }
    }
}
