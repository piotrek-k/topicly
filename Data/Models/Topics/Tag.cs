using System.Collections;
using System.Collections.Generic;

namespace Data.Models.Topics
{
    public class Tag
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        /// <summary>
        /// Ilość tematów posiadających ten tag
        /// </summary>
        public int NumberOfTopicsUsing => Topics.Count;

        /// <summary>
        /// Lista tematów posiadających ten tag
        /// </summary>
        public ICollection<Topic> Topics { get; set; }
        public List<TopicTag> TopicTags { get; set; }
    }
}