﻿using Microsoft.AspNetCore.Identity;
using System;

namespace IdentityServer.Models {
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean? OptIn { get; set; }
    }
}
