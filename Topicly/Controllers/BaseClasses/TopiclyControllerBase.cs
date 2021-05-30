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

        public async Task<ApplicationUser> GetCurrentUser()
        {
            var userIdentity = HttpContext.User.Identity;

            if (userIdentity == null)
            {
                return null;
            }

            var user = await UserManager.FindByEmailAsync(userIdentity.Name);
            return user;
        }
    }
}
