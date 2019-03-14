using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Helpers;

namespace UniversalSystemCenter.Core.Cache.CSRedis
{
    public static class RedisExtendHelper
    {
        /// <summary>
        /// 从缓存中获取单个值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static  T Get<T>(string key) where T : class, new()
        {
            var value = RedisHelper.Get(key);
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    return Json.ToObject<T>(value);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 从缓存中获取单个值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(string key) where T : class, new()
        {
            var value = await RedisHelper.GetAsync(key);
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    return Json.ToObject<T>(value);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
