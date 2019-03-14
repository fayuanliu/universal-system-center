using CSRedis;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Cache
{
    /// <summary>
    /// 注册RedisHelper
    /// </summary>
    public static class RedisConfig
    {
        /// <summary>
        /// 初始化RedisHelper
        /// </summary>
        /// <param name="service"></param>
        /// <param name="redisConnection">Redis链接字符串</param>
        /// <param name="isDistributed">是否分布式缓存</param>
        /// <returns></returns>
        public static IServiceCollection AddRedis(this IServiceCollection service, string redisConnection, bool isDistributed = true)
        {
            if (string.IsNullOrWhiteSpace(redisConnection))
            {
                throw new Exception("Redis链接字符串不能为空");
            }

            var redis = new CSRedisClient(redisConnection);
            RedisHelper.Initialization(redis);
            if (isDistributed)
            {
                service.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
            }
            return service;
        }
    }
}
