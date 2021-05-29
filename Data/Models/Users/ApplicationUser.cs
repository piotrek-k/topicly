﻿using Microsoft.AspNetCore.Identity;

namespace Data.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        public string Nickname { get; set; }
    }
}
