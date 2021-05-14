using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        /// <summary>
        /// Lista czatów dla zalogowanego użytkownika
        /// </summary>
        [HttpGet("GetAllForCurrentUser")]
        public IEnumerable<ChatViewModel> GetChatsForUser()
        {
            // TODO: Zwracać tylko czaty należące do użytkownika
            var chats = _context.Chats.Include(x => x.Topic).ToList();
            return chats.Select(x => x.ToViewModel());
        }
    }
}