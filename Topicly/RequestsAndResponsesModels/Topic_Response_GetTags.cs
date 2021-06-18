using System.Collections.Generic;

namespace Topicly.RequestsAndResponsesModels
{
    public class Topic_Response_GetTags
    {
        public List<GetTags_Tag> Tags { get; set; } = new List<GetTags_Tag>();

        public class GetTags_Tag
        {
            public string Name { get; set; }
            public int Popularity { get; set; }
        }
    }
}