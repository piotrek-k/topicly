using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Data;
using Topicly.Data.Models.Chat;
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

        /// <summary>
        /// POST
        /// Tworzy czat na podstawie tematu
        /// </summary>
        /// <param name="topicId">Identyfikator wybranego tematu</param>
        /// <returns>Unikalny identyfikator utworzonego czatu</returns>
        [HttpPost("ChooseChat")]
        public async Task<ActionResult> CreateChat(int topicId)
        {
            var dbTopic = await _context.Topics.FirstOrDefaultAsync(x => x.Id == topicId);
            if (dbTopic == null)
            {
                return NotFound("Podany temat nie istnieje");
            }

            var addedChat = await _context.Chats.AddAsync(new Chat()
            {
                TopicCreator = dbTopic.CreatedBy,
                TopicAnswerer = "example_user_1",
                TopicId = dbTopic.Id
            });
            await _context.SaveChangesAsync();

            return Ok(addedChat.Entity.Id);
        }
    }
}