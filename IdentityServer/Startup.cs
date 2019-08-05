using IdentityServer.Extensions;
using IdentityServer.Filters;
using IdentityServer.Tools.LogMachine;
using IdentityServer4.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityServer {
    public class Startup {

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

            services.ConfigureIdentity();

            services.ConfigureIdentityServer();

            //must be called AFTER configureIdentityServer
            services.ConfigureIoC(Configuration);

            services.ConfigureCors();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedProto | ForwardedHeaders.XForwardedHost | ForwardedHeaders.All;
            });
            services.AddMvcCore(o =>
            {
                o.Filters.Add(typeof(LogFilter));
                o.Filters.Add(typeof(PratchettFilter));
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
            app.UseMiddleware<PublicFacingUrlMiddleware>(Configuration["IdentityServerPublicFacingUri"]);
            app.UseCors("CorsPolicy");
            app.UseForwardedHeaders();
            //app.UseForwardedHeaders(new ForwardedHeadersOptions
            //{
            //    ForwardedHeaders = ForwardedHeaders.All
            //});


            app.UseIdentityServer();
            app.UseAuthentication();

            app.UseCors("CorsPolicy");
            app.UseMiddleware<IdentityServerMiddleware>();
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
