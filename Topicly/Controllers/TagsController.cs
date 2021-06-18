using System;
using System.Threading.Tasks;
using Data;
using Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Topicly.Controllers.BaseClasses;

namespace Topicly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TagsController : TopiclyControllerBase
    {
        private ApplicationDbContext _context;
        private ILogger<TopicsController> _logger;
        private UserManager<ApplicationUser> _userManager;

        public TagsController(ApplicationDbContext context, ILogger<TopicsController> logger,
            UserManager<ApplicationUser> userManager)
            : base(userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        /// <summary>
        /// Zwraca popularność (ilość powiązanych tematów) dla danego tagu
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetPopularityForTag")]
        public async Task<ActionResult<int>> GetPopularityForTag(string tagName)
        {
            var inDb = await _context.Tags
                .Include(x => x.Topics)
                .FirstOrDefaultAsync(x =>
                    x.Name.Equals(tagName.ToLower().Trim()));

            return inDb?.NumberOfTopicsUsing ?? 0;
        }
    }
}