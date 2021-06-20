using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Topicly.Options;

namespace Topicly.Services
{
    public class AzureTagExtractor : ITagExtractor
    {
        private readonly string _key;
        private readonly string _endpointUrl;

        public AzureTagExtractor(IOptions<AzureTagExtractorOptions> options)
        {
            _endpointUrl = options.Value.EndpointUrl;
            _key = options.Value.KeyFile;
        }

        private class Request
        {
            public class Document
            {
                public string Language { get; set; } = "pl";
                public int Id { get; set; } = 1;
                public string Text { get; set; }
            }
            public List<Document> Documents { get; set; }
        }

        private class Response
        {
            public class Document
            {
                public List<string> KeyPhrases { get; set; }
            }

            public List<Document> Documents { get; set; }
        }

        public async Task<IEnumerable<string>> GetTags(string text)
        {
            var request = new Request
            {
                Documents = new List<Request.Document>
                {
                    new() { Text = text }
                }
            };

            var reqJson = JsonConvert.SerializeObject(request);
            var uri = $"{_endpointUrl}text/analytics/v3.0/keyPhrases";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes(reqJson);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
            }

            var respJson = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<Response>(respJson);

            var tags = resp.Documents[0].KeyPhrases
                .SelectMany(s => s.Split(' '))
                .Select(s => s.ToLowerInvariant())
                .Distinct()
                .ToList();

            return tags;
        }
    }
}