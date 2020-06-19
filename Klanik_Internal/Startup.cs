using Klanik_Internal.Extensions;
using Klanik_Internal.Filters;
using Klanik_Internal.LogMachines;
using Klanik_Internal.Models;
using Klanik_Internal.Models.ConfigValues;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Logging;
using Swashbuckle.AspNetCore.Filters;
//Swagger
using Swashbuckle.AspNetCore.Swagger;


namespace Klanik_Internal {
    public class Startup {
        public readonly IHostingEnvironment HostingEnvironment;
        private ILogMachine _logMachine;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            HostingEnvironment = env;
            Configuration = configuration;
            _logMachine = new LogMachine();
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var physicalProvider = HostingEnvironment.ContentRootFileProvider;
            services.AddSingleton(physicalProvider);

            services.Configure<PdfConfig>(Configuration.GetSection("PdfConfig"));
            services.Configure<CORS>(Configuration.GetSection("Cors"));
            services.Configure<JwtBearerConfig>(Configuration.GetSection("JwtBearer"));

            services.ConfigureIoC(Configuration);

            services.ConfigureCors();

            services.AddNodeServices();

            services.ConfigureIisIntegration();

            services.AddDbContext<KlanikContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:KlanikDb"])
                .EnableSensitiveDataLogging(true)
                );



            services.ConfigureAuthentication(services.BuildServiceProvider().GetRequiredService<IOptions<JwtBearerConfig>>().Value);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

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

            services.AddMvcCore(options =>
            {
                options.Filters.Add(typeof(ValidateModelFilter));
                options.Filters.Add(typeof(LogFilter));
            });

        }

         public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                 app.UseHsts();
            }

            IdentityModelEventSource.ShowPII = true; 
            
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
