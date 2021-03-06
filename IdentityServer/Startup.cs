﻿using IdentityServer.Extensions;
using IdentityServer.Models;
using IdentityServer.Models.MailSender;
using IdentityServer.Repository;
using IdentityServer.Services;
using IdentityServer.Tools.ContextInitializer;
using IdentityServer.Tools.LogMachine;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdentityServer
{
    public class Startup
    {

        private IHostingEnvironment _hostingEnvironment;
        private ILogMachine _logMachine;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _hostingEnvironment = env;
            Configuration = configuration;
            _logMachine = new LogMachine(env.ContentRootFileProvider);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var physicalProvider = _hostingEnvironment.ContentRootFileProvider;
            services.AddSingleton(physicalProvider);


            services.AddDbContext<KlanikIdentityContext>(o =>
                o.UseSqlServer(Configuration["ConnectionString:IdentityDb"])
            );

            //services and config
            services.AddScoped<IServiceProvider, ServiceProvider>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration.GetSection("AuthMessageSenderOptions"));
            services.Configure<FrontConfig>(Configuration.GetSection("FrontConfig"));

            //identity db initialization
            services.AddTransient<IStarter, Starter>();

            services.AddTransient<ILogMachine, LogMachine>();

            services.AddIdentity<ApplicationUser, IdentityRole>(c => {
                c.SignIn.RequireConfirmedEmail = true;
                })
                .AddEntityFrameworkStores<KlanikIdentityContext>()
                .AddDefaultTokenProviders();

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryPersistedGrants()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryClients(Config.GetClients())
                .AddProfileService<IdentityClaimsProfileService>()
                .AddAspNetIdentity<ApplicationUser>();


            services.AddTransient<IProfileService, IdentityClaimsProfileService>();


            services.ConfigureCors();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            //clacks - overhead
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Clacks-Overhead", "GNU Terry Pratchett");
                await next.Invoke();
            });

            //log request/response headers
            app.Use(async (context, next) =>
            {
                _logMachine.Log("Request incoming");

                foreach (var item in context.Request.Headers)
                {
                    _logMachine.Log("Request header " + item.Key + " : " + item.Value);
                }


                _logMachine.Log("Response incoming");
                foreach (var item in context.Response.Headers)
                {
                    _logMachine.Log("Response header " + item.Key + " : " + item.Value);
                }


                await next.Invoke();
            });

            app.UseIdentityServer();
            app.UseAuthentication();

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
