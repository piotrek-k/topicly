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

        [HttpGet]
        public IEnumerable<MessageViewModel> GetMessagesForChat(int chatId)
        {
            // TODO: Zwracać tylko wiadomości należące do czatu
            return _context.Messages.ToList().Select(x => x.ToViewModel());
        }
    }
}