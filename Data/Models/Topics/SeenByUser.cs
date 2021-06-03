using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Topics
{
    /// <summary>
    /// Zawiera tematy które dany użytkownik już widział
    /// </summary>
    public class SeenByUser
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }
        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; }
    }
}