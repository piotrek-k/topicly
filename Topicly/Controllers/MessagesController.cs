using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : Controller

    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MessagesController> _logger;
        private readonly IMapper _mapper;

        public MessagesController(ApplicationDbContext context, ILogger<MessagesController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Lista wszystkich wiadomości wysłanych w ramach czatu
        /// </summary>
        /// <param name="chatId">Identyfikator czatu</param>
        [HttpGet("GetForChat/{chatId}")]
        public IEnumerable<MessageViewModel> GetMessagesForChat(int chatId)
        {
            // TODO: Zwracać tylko wiadomości należące do czatu
            return _context.Messages.Where(y => y.ChatId == chatId).Select(x => _mapper.Map<MessageViewModel>(x)).ToList();
        }
    }
}