using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Data.UnitOfWorks.MySql;
using Util;
using Util.Datas.Ef;
using Util.Logs.Extensions;
using Util.Webs.Extensions;

namespace UniversalSystemCenter
{
    /// <summary>
    /// 启动配置
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 初始化启动配置
        /// </summary>
        /// <param name="configuration">配置</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 配置
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 配置服务
        /// </summary>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //添加Mvc服务
            services.AddMvc(options =>
            {
                //options.Filters.Add( new AutoValidateAntiforgeryTokenAttribute() );
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //添加NLog日志操作
            services.AddNLog();

            //添加EasyCaching缓存
            // services.AddCache(options => options.UseInMemory());

            //添加业务锁
            // services.AddLock();

            //注册XSRF令牌服务
            services.AddXsrfToken();

            //添加EF工作单元
            //====== 支持Sql Server 2012+ ==========
            //services.AddUnitOfWork<IUniversalSysCenterUnitOfWork, UniversalSysCenterUnitOfWork>(Configuration.GetConnectionString("DefaultConnection"));
            //======= 支持Sql Server 2005+ ==========
            //services.AddUnitOfWork<ISampleUnitOfWork, Util.Samples.Webs.Data.SqlServer.SampleUnitOfWork>( builder => {
            //    builder.UseSqlServer( Configuration.GetConnectionString( "DefaultConnection" ), option => option.UseRowNumberForPaging() );
            //} );
            //======= 支持PgSql =======
            //services.AddUnitOfWork<ISampleUnitOfWork, Util.Samples.Webs.Data.PgSql.SampleUnitOfWork>( Configuration.GetConnectionString( "PgSqlConnection" ) );
            //======= 支持MySql =======
            services.AddUnitOfWork <IUniversalSysCenterUnitOfWork, UniversalSysCenterUnitOfWork>(Configuration.GetConnectionString("DefaultConnection"));

            //添加Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "统一系统配制中心", Version = "v1" });
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "UniversalSystemCenter.Api.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "UniversalSystemCenter.Services.xml"));
            });

            services.AddAuthentication("Bearer")
               .AddIdentityServerAuthentication(options =>
               {
                   options.RequireHttpsMetadata = false;
                   options.Authority = Configuration.GetSection("AuthHost")["Authority"];
                   options.ApiName = "System_Api";
               });

            // 添加Razor静态Html生成器
            //services.AddRazorHtml();

            //添加事件总线
            //services.AddEventBus();

            //添加Cap事件总线
            //services.AddEventBus( options => {
            //    options.UseDashboard();
            //    options.UseSqlServer( Configuration.GetConnectionString( "DefaultConnection" ) );
            //    options.UseRabbitMQ( "192.168.244.138" );
            //} );

            //添加Util基础设施服务
            return services.AddUtil();
        }

        /// <summary>
        /// 配置开发环境请求管道
        /// </summary>
        public void ConfigureDevelopment(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
            app.UseSwaggerX();
            CommonConfig(app);
        }

        /// <summary>
        /// 配置生产环境请求管道
        /// </summary>
        public void ConfigureProduction(IApplicationBuilder app)
        {
            app.UseExceptionHandler("/Home/Error");
            CommonConfig(app);
        }

        /// <summary>
        /// 公共配置
        /// </summary>
        private void CommonConfig(IApplicationBuilder app)
        {
            app.UseErrorLog();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseXsrfToken();
            ConfigRoute(app);
        }

        /// <summary>
        /// 路由配置,支持区域
        /// </summary>
        private void ConfigRoute(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute("areaRoute", "view/{area:exists}/{controller}/{action=Index}/{id?}");
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                routes.MapSpaFallbackRoute("spa-fallback", new { controller = "Home", action = "Index" });
            });
        }
    }
}
