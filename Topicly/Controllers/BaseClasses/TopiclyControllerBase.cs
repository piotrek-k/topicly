using System.Security.Claims;
using System.Threading.Tasks;
using Data.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Topicly.Controllers.BaseClasses
{
    public class TopiclyControllerBase : Controller
    {
        protected UserManager<ApplicationUser> UserManager { get; }

        public TopiclyControllerBase(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }

        [NonAction]
        public async Task<ApplicationUser> GetCurrentUser()
        {
            var userIdentity = HttpContext.User.Identity;

            if (userIdentity == null)
            {
                return null;
            }

            var user = await UserManager.FindByNameAsync(userIdentity.Name);
            return user;
        }

        [NonAction]
        public string GetCurrentUserId()
        {
            return HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
