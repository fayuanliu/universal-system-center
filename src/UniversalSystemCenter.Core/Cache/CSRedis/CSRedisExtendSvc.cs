using CSRedis;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Cache.CSRedis
{
    public static class CSRedisExtendSvc
    {
        /// <summary>
        /// CSRedis注册并初始化
        /// </summary>
        /// <param name="services"></param>
        /// <param name="csRedisConn">Redis地址链接</param>
        /// <returns></returns>
        public static IServiceCollection AddCSRedisIocAndInit(this IServiceCollection services,string csRedisConn)
        {
            var csRedis = new CSRedisClient(csRedisConn);
            RedisHelper.Initialization(csRedis);
            services.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
            return services;
        }
    }
}
