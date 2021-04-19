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
    public class ChatsController : Controller

    {
        private readonly ApplicationContext _context;
        private readonly ILogger<ChatsController> _logger;

        public ChatsController(ApplicationContext context, ILogger<ChatsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ChatViewModel> GetChatsForUser()
        {
            // TODO: Zwracać tylko czaty należące do użytkownika
            return _context.Chats.ToList().Select(x => x.ToViewModel());
        }
    }
}