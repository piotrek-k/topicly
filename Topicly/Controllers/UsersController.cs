﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Data.Models.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Topicly.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> CreateUser(string email, string password, bool rememberMe)
        {
            var newUser = new ApplicationUser { Email = email, UserName = email };
            var result = await _userManager.CreateAsync(newUser, password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(newUser, new AuthenticationProperties { IsPersistent = rememberMe });
            }
            else
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> SignInUser(string email, string password, bool rememberMe)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, password);

            if (isPasswordCorrect)
            {
                await _signInManager.SignInAsync(user, rememberMe);
            }
            else
            {
                return Unauthorized("Incorrect password");
            }

            return Ok();
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetUserEmail()
        {
            return Ok(await Task.FromResult(_userManager.GetUserName(HttpContext.User)));
        }

        [HttpPost("sign-out")]
        public async Task<IActionResult> LogOutUsers()
        {
            try
            {
                await _signInManager.SignOutAsync();
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
