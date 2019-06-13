using Klanik_Internal.LogMachines;
using Klanik_Internal.Models;
using Klanik_Internal.Models.ConfigValues;
using Klanik_Internal.Repository;
using Klanik_Internal.Services;
using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:8080")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureAuthentication(this IServiceCollection services, JwtBearerConfig jwtConfig)
        {
            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.Authority = jwtConfig.Authority;
                o.Audience = jwtConfig.Audience;
                o.RequireHttpsMetadata = false;
            });
        }

        public static void ConfigureIoC(this IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<PdfConfig>(Configuration.GetSection("PdfConfig"));
            services.Configure<CORS>(Configuration.GetSection("Cors"));
            services.Configure<JwtBearerConfig>(Configuration.GetSection("JwtBearer"));

            services.AddScoped<IServiceProvider, ServiceProvider>();
            services.AddScoped<IMapper, Mapper>();
            services.AddScoped<IService<Konsultant>, KonsultantService>();
            services.AddScoped<IService<Recruiter>, RecruiterService>();
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

            services.AddScoped<ILogMachine, LogMachine>();

            services.AddTransient<IGenerator, TemplateGenerator>();
        }

    }
}
