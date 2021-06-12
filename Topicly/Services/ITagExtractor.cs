using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topicly.Services
{
    public interface ITagExtractor
    {
        public Task<IEnumerable<string>> GetTags(string text);
    }
}
