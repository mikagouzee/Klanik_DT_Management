using IdentityServer.Models;
using IdentityServer.Models.MailSender;
using IdentityServer.Repository;
using IdentityServer.Services;
using IdentityServer.Tools.ContextInitializer;
using IdentityServer.Tools.LogMachine;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdentityServer.Extensions {
    public static class ServicesExtensions {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder.WithOrigins("*")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(c =>
            {
                c.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<KlanikIdentityContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureIdentityServer(this IServiceCollection services)
        {
            services.AddIdentityServer(o => o.IssuerUri = "https://klanikiat.ddns.net/")
                .AddDeveloperSigningCredential()
                .AddInMemoryPersistedGrants()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryClients(Config.GetClients())
                .AddProfileService<IdentityClaimsProfileService>()
                .AddAspNetIdentity<ApplicationUser>();
        }

        public static void ConfigureIoC(this IServiceCollection services, IConfiguration Configuration)
        {
            //services and config
            services.AddScoped<IServiceProvider, ServiceProvider>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddTransient<IEmailSender, EmailSender>();

            //identity db initialization
            services.AddTransient<IStarter, Starter>();

            services.AddTransient<ILogMachine, LogMachine>();
            services.AddTransient<UserManager<IdentityUser>>();
            services.Configure<AuthMessageSenderOptions>(Configuration.GetSection("AuthMessageSenderOptions"));
            services.Configure<FrontConfig>(Configuration.GetSection("FrontConfig"));

            services.AddTransient<IProfileService, IdentityClaimsProfileService>();

        }
    }
}
