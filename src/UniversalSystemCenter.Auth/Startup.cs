using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Data.UnitOfWorks.MySql;
using Util;
using Util.Datas.Ef;
using Util.Dependency;

namespace UniversalSystemCenter.Auth
{
    public class Startup
    {
        private readonly IHostingEnvironment _environment;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            _environment = env;

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //EF上下文
            services.AddUnitOfWork<IUniversalSysCenterUnitOfWork, UniversalSysCenterUnitOfWork>(Configuration.GetConnectionString("DefaultConnection"));
            services.AddIdentityServer()
                  .AddDeveloperSigningCredential()
                  .AddInMemoryIdentityResources(Config.IdentityConfig.GetIdentityResourceResources())
                  .AddInMemoryApiResources(Config.IdentityConfig.GetApiResources())
                  .AddInMemoryClients(Config.IdentityConfig.GetClients())
                  .AddResourceOwnerValidator<ResourceOwnerPasswordValidator>()
                  .AddProfileService<ProfileService>();
            return services.AddUtil(new IConfig[] { new Service.Configs.IocConfig() });
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseIdentityServer();
        }
    }
}
