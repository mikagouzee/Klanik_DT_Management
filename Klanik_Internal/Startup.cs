using Klanik_Internal.Extensions;
using Klanik_Internal.LogMachines;
using Klanik_Internal.Models;
using Klanik_Internal.Models.ConfigValues;
using Klanik_Internal.Repository;
using Klanik_Internal.Services;
using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Swashbuckle.AspNetCore.Filters;
//Swagger
using Swashbuckle.AspNetCore.Swagger;
using System;


namespace Klanik_Internal {
    public class Startup {

        private IHostingEnvironment _hostingEnvironment;
        private ILogMachine _logMachine;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _hostingEnvironment = env;
            Configuration = configuration;
            _logMachine = new LogMachine();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var physicalProvider = _hostingEnvironment.ContentRootFileProvider;
            services.AddSingleton(physicalProvider);

            services.Configure<PdfConfig>(Configuration.GetSection("PdfConfig"));
            services.Configure<CORS>(Configuration.GetSection("Cors"));

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

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IService<Certificate>, CertificateService>();
            services.AddScoped<IService<Language>, LanguageService>();
            services.AddScoped<IService<Competence>, CompetenceService>();
            services.AddScoped<IService<TechnicalEnvironment>, TechnicalEnvironmentService>();
            services.AddScoped<IService<Education>, EducationService>();
            services.AddScoped<IService<ProfessionalExperience>, ProfessionalExperienceService>();
            services.AddScoped<IService<ProfessionalReference>, ProfessionalReferenceService>();
            services.AddScoped<IService<Accomplishment>, AccomplishmentService>();
            services.AddScoped<IService<Models.Contact>, ContactService>();

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.Authority = "http://localhost:54433";
                o.Audience = "api1";
                o.RequireHttpsMetadata = false;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IGenerator, TemplateGenerator>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "Klanik API - Swagger ", Version = "v1" });
                // Handle OAuth
                options.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = "header",
                    Name = "Authorization",
                    Type = "apiKey"
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });

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
            IdentityModelEventSource.ShowPII = true; //Add this line
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

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Klanik API");
            });
        }
    }

}
