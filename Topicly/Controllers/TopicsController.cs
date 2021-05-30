using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Models.Chats;
using Data.Models.Topics;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Controllers.BaseClasses;
using Topicly.ViewModels;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TopicsController : TopiclyControllerBase
    {
        private ApplicationDbContext _context;
        private readonly ILogger<TopicsController> _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public TopicsController(ApplicationDbContext context, ILogger<TopicsController> logger, IMapper mapper,
            UserManager<ApplicationUser> userManager)
            : base(userManager)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
        }
        
        /// <summary>
        /// Zwraca spersonalizowaną propozycję nowego tematu
        /// </summary>
        [HttpGet("ProposeNext")]
        public async Task<TopicViewModel> ProposeNext()
        {
            var user = await GetCurrentUser();

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

            var user = await GetCurrentUser();

            var addedChat = await _context.Chats.AddAsync(new Chat()
            {
                TopicCreator = dbTopic.CreatedBy,
                TopicAnswerer = user.Id,
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
            var user = GetCurrentUser();
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
            var user = await GetCurrentUser();

            await _context.Topics.AddAsync(new Topic
            {
                Name = topicCreationViewModel.Content,
                CreatedBy = user.Id
            });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}