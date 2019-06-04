using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace IdentityServer.Tools.ContextInitializer {
    public class Starter : IStarter {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public Starter(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

        }

        public void Seed()
        {
            try
            {
                Task.Run(async () =>
                {
                    await SetupRoles();
                    await SetupUsers();
                    await SetRolestoUser();

                }).Wait();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SetupRoles()
        {
            string[] roles = new string[]
            {
                "Basic User",
                "Admin",
                "SuperUser"
            };

            foreach (var role in roles)
            {
                if (await _roleManager.FindByNameAsync(role) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }

            }

        }

        public async Task SetupUsers()
        {
            ApplicationUser[] users = new ApplicationUser[]
            {
                new ApplicationUser{
                    UserName = "Sebastien_Verhaegen",
                    FirstName = "Sebastien",
                    LastName = "Verhaegen",
                    Email = "sverhaegen@klanik.com",
                    EmailConfirmed = true

                },
                new ApplicationUser
                {
                    UserName = "SuperUser",
                    FirstName = "Super",
                    LastName = "User",
                    Email = "mgouzee@klanik.com",
                    EmailConfirmed = true
                },

            };

            foreach (var user in users)
            {
                if (await _userManager.FindByNameAsync(user.UserName) == null)
                {
                    await _userManager.CreateAsync(user, "ResetTh!s1");

                    await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("userName", user.UserName));
                    await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("firstName", user.FirstName));
                    await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("lastName", user.LastName));
                    await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("email", user.Email));
                }
            }
        }


        public async Task SetRolestoUser()
        {
            var seb = await _userManager.FindByNameAsync("Sebastien_Verhaegen");

            if (seb != null)
            {
                var admin = await _roleManager.FindByNameAsync("Admin");

                if (admin == null)
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));

                await _userManager.AddToRoleAsync(seb, "Admin");
                await _userManager.AddClaimAsync(seb, new System.Security.Claims.Claim("role", "Admin"));
            }

            var topUser = await _userManager.FindByNameAsync("SuperUser");

            if (topUser != null)
            {
                var superUser = await _roleManager.FindByNameAsync("SuperUser");
                if (superUser == null)
                    await _roleManager.CreateAsync(new IdentityRole("SuperUser"));

                await _userManager.AddToRoleAsync(topUser, "SuperUser");
                await _userManager.AddClaimAsync(topUser, new System.Security.Claims.Claim("role", "SuperUser"));
            }

        }


    }

    public interface IStarter {
        void Seed();
    }

}
