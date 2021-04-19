using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Data;
using Topicly.Data.Models.Topics;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : Controller
    {
        private ApplicationContext _context;
        private readonly ILogger<TopicController> _logger;

        public TopicController(ApplicationContext context, ILogger<TopicController> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        /// <summary>
        /// GET
        /// Spersonalizaowana propozycja nowego tematu
        /// </summary>
        [HttpGet("ProposeNext")]
        public async Task<TopicViewModel> ProposeNext()
        {
            // TODO: Algorytm generowania propozycji
            var dbTopic = await _context.Topics.FirstOrDefaultAsync();
            return dbTopic.ToViewModel();
        }
    }
}