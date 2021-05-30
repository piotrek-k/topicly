using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using Data.Models.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Topicly.Controllers.BaseClasses;
using Topicly.RequestsAndResponsesModels;

namespace Topicly.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : TopiclyControllerBase
    {
        private SignInManager<ApplicationUser> SignInManager { get; }
        private IMapper AutoMapper { get; }

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMapper autoMapper)
            : base(userManager)
        {
            SignInManager = signInManager;
            AutoMapper = autoMapper;
        }

        [HttpPost("sign-up")]
        [AllowAnonymous]
        public async Task<IActionResult> SignUpUser([FromBody] User_Request_SignUp req)
        {
            var newUser = AutoMapper.Map<User_Request_SignUp, ApplicationUser>(req);
            var result = await UserManager.CreateAsync(newUser, req.Password);

            if (result.Succeeded)
            {
                await SignInManager.SignInAsync(newUser, new AuthenticationProperties { IsPersistent = req.RememberMe });
            }
            else
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpPost("sign-in")]
        [AllowAnonymous]
        public async Task<IActionResult> SignInUser([FromBody] User_Request_SignIn req)
        {
            var user = await UserManager.FindByEmailAsync(req.Email);
            if (user == null)
            {
                return BadRequest("No account exists for the given e-mail address");
            }

            var passwordCorrect = await UserManager.CheckPasswordAsync(user, req.Password);
            if (passwordCorrect == false)
            {
                return BadRequest("Incorrect password");
            }

            await SignInManager.SignInAsync(user, req.RememberMe);
            return Ok();
        }

        [HttpPost("sign-out")]
        public async Task<IActionResult> SignOutUser()
        {
            await SignInManager.SignOutAsync();
            return Ok();
        }

        [HttpPatch("change-username")]
        public async Task<IActionResult> ChangeUserName([FromBody] User_Request_ChangeName req)
        {
            var user = await GetCurrentUser();
            var result = await UserManager.SetUserNameAsync(user, req.NewUserName);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpPatch("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] User_Request_ChangePassword req)
        {
            var user = await GetCurrentUser();
            var result = await UserManager.ChangePasswordAsync(user, req.CurrentPassword, req.NewPassword);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser()
        {
            var user = await GetCurrentUser();
            var result = await UserManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }
    }
}
