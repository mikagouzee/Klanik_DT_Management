using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Klanik_Internal.Extensions;
using Klanik_Internal.LogMachines;
using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using Klanik_Internal.Services;
using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Klanik_Internal
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

            services.ConfigureCors();

            services.AddNodeServices();

            services.ConfigureIISIntegration();
            services.AddDbContext<KlanikContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:KlanikDb"])
                .EnableSensitiveDataLogging(true)
                );

            services.AddScoped<IServiceProvider, ServiceProvider>();

            services.AddScoped<IMapper, Mapper>();
            services.AddScoped<IService<Konsultant>, KonsultantService>();

            services.AddScoped<IRepository<Konsultant>, KonsultantRepository>();

            //services.AddScoped<IRepository<Certificate>, CertificateRepository>();
            //services.AddScoped<IRepository<Language>, LanguageRepository>();
            //services.AddScoped<IRepository<Competence>, CompetenceRepository>();
            //services.AddScoped<IRepository<TechnicalEnvironment>, TechnicalEnvironmentRepository >();
            //services.AddScoped<IRepository<Education>, EducationRepository>();
            //services.AddScoped<IRepository<ProfessionalExperience>, ProfessionalExperienceRepository>();
            //services.AddScoped<IRepository<ProfessionalReference>, ProfessionalReferenceRepository>();
            //services.AddScoped<IRepository<Accomplishment>, AccomplishmentRepository>();
            //services.AddScoped<IRepository<Contact>, ContactRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IService<Certificate>, CertificateService>();
            services.AddScoped<IService<Language>, LanguageService>();
            services.AddScoped<IService<Competence>, CompetenceService>();
            services.AddScoped<IService<TechnicalEnvironment>, TechnicalEnvironmentService>();
            services.AddScoped<IService<Education>, EducationService>();
            services.AddScoped<IService<ProfessionalExperience>, ProfessionalExperienceService>();
            services.AddScoped<IService<ProfessionalReference>, ProfessionalReferenceService>();
            services.AddScoped<IService<Accomplishment>, AccomplishmentService>();
            services.AddScoped<IService<Contact>, ContactService>();

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddJwtBearer(o =>
            {
                o.Authority = "https://localhost:44363";
                o.Audience = "api1";
                //o.ForwardAuthenticate = true;
                o.RequireHttpsMetadata = false;
            });
            #region commented out



            // MVC AND COOKIES : https://www.developpez.net/forums/blogs/137868-hinault-romaric/b6763/identityserver4-creation-configuration-d-client-utilisant-openid-connect/
            //services.Configure<CookiePolicyOptions>(o =>
            //{
            //    o.CheckConsentNeeded = context => true;
            //    o.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            //services.AddAuthentication(o =>
            //{
            //    o.DefaultScheme = "Cookies";
            //    o.DefaultChallengeScheme = "oidc";
            //})
            //.AddCookie("Cookies")
            //.AddOpenIdConnect("oidc", o =>
            //{
            //    o.SignInScheme = "Cookies";
            //    o.Authority = "https://localhost:44363";
            //    o.RequireHttpsMetadata = false;
            //    o.ClientId = "ro.VueJs";
            //    o.SaveTokens = true;
            //});

            ////https://www.developpez.net/forums/blogs/137868-hinault-romaric/b6378/securisation-d-web-api-asp-net-core-sts-identityserver4/
            //services.AddAuthentication("Bearer")
            //    .AddIdentityServerAuthentication(o =>
            //    {
            //        o.Authority = "https://localhost:44363";
            //        o.RequireHttpsMetadata = false;

            //        o.ApiName = "api1";
            //    });
            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IGenerator, TemplateGenerator>();
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

            app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
