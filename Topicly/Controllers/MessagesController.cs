using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Topicly.Data;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : Controller

    {
        private readonly ApplicationContext _context;
        private readonly ILogger<MessagesController> _logger;

        public MessagesController(ApplicationContext context, ILogger<MessagesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Lista wszystkich wiadomości wysłanych w ramach czatu
        /// </summary>
        /// <param name="chatId">Identyfikator czatu</param>
        [HttpGet("GetForChat/{chatId}")]
        public IEnumerable<MessageViewModel> GetMessagesForChat(int chatId)
        {
            // TODO: Zwracać tylko wiadomości należące do czatu
            return _context.Messages.Where(y => y.ChatId == chatId).ToList().Select(x => x.ToViewModel());
        }
    }
}