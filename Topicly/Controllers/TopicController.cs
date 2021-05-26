using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Models.Chats;
using Data.Models.Topics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : Controller
    {
        private ApplicationDbContext _context;
        private readonly ILogger<TopicController> _logger;
        private readonly IMapper _mapper;

        public TopicController(ApplicationDbContext context, ILogger<TopicController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Zwraca spersonalizowaną propozycję nowego tematu
        /// </summary>
        [HttpGet("ProposeNext")]
        public async Task<TopicViewModel> ProposeNext()
        {
            // TODO: Algorytm generowania propozycji
            var numberOfTopics = await _context.Topics.CountAsync();
            var chosenTopic = new Random().Next(numberOfTopics);

            var dbTopic = await _context.Topics.Skip(chosenTopic).FirstOrDefaultAsync();
            return _mapper.Map<TopicViewModel>(dbTopic);
        }

        /// <summary>
        /// Tworzy czat na podstawie tematu
        /// </summary>
        /// <param name="topicId">Identyfikator wybranego tematu</param>
        /// <response code="200">Zwraca w odpowiedzi unikalny identyfikator utworzonego czatu</response>
        /// <response code="404">Gdy nie znaleziono podanego identyfikatora tematu w bazie</response>
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

        /// <summary>
        /// Wysłać w momencie gdy użytkownikowi użytkownik odrzuci zaproponowany temat.
        /// Charakter informacyjny; żeby algorytm miał próbki tematów które nie interesują użytkownika.
        /// </summary>
        /// <param name="topicId">Identyfikator tematu</param>
        [HttpPost("RejectTopicProposal")]
        public async Task<ActionResult> RejectTopicProposal(int topicId)
        {
            if (await _context.Topics.AnyAsync(x => x.Id == topicId))
            {
                // TODO: zapisz wzmiankę o zdarzeniu w bazie 

                return Ok();
            }

            return NotFound("Podany temat nie istnieje");
        }

        /// <summary>
        /// Tworzy propozycję nowego tematu
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateTopic")]
        public async Task<ActionResult> CreateTopic([FromBody] TopicCreationViewModel topicCreationViewModel)
        {
            await _context.Topics.AddAsync(new Topic()
            {
                Name = topicCreationViewModel.Content,
                CreatedBy = "username", //TODO: ustawić prawdziwą nazwę użytkownika

            });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}