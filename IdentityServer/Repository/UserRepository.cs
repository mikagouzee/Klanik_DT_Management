﻿using IdentityServer.Models.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IServiceProvider _provider;

        public UserRepository(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IEnumerable<ProfileViewModel> GetAllUsers()
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikIdentityContext context = _provider.GetService<KlanikIdentityContext>();

                return context.Users.Select(x => new ProfileViewModel(x));
            }
        }

        public IEnumerable<string> GetAllRoles()
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikIdentityContext context = _provider.GetService<KlanikIdentityContext>();

                var result = context.Roles
                    .Where(x => x.Name != "SuperUser")
                    .Select(x => x.Name);

                return result;
            }
        }

    }

    public interface IUserRepository
    {
        IEnumerable<ProfileViewModel> GetAllUsers();

        IEnumerable<string> GetAllRoles();
    }

}
