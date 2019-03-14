using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Util.Webs.Clients;
using UniversalSystemCenter.Core.SysKey;

namespace UniversalSystemCenter.Core.Cache
{
    /// <summary>
    /// 缓存帮助类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CacheHelper<T>
    {
        /// <summary>
        /// 缓存数据
        /// </summary>
        public List<T> CacheData = null;

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="cacheName">缓存名称</param>
        /// <param name="predicate">筛选条件</param>
        /// <returns></returns>
        public List<T> GetData(string cacheName, Func<T, bool> predicate = null)
        {
            if (string.IsNullOrWhiteSpace(cacheName))
            {
                return new List<T>();
            }

            try
            {
                var cacheData = Get(cacheName, predicate);

                if (cacheData.Count() == 0)
                {
                    cacheData = Get(cacheName, predicate);
                }

                return cacheData;
            }
            catch (Exception ex)
            {
                return new List<T>();
            }
        }

        private List<T> Get(string cacheName, Func<T, bool> predicate = null)
        {
            if (null == CacheData)
            {
                var cache = RedisHelper.Get(cacheName);
                if (null == cache)
                {
                    Refresh(cacheName);
                    cache = RedisHelper.Get(cacheName);
                }

                if (null == cache)
                {
                    return new List<T>();
                }

                CacheData = Util.Helpers.Json.ToObject<List<T>>(cache);
            }

            var result = (List<T>)CacheData;

            if (null != predicate)
            {
                result = result.Where(predicate).ToList();
            }

            if (result.Count() == 0)
            {
                Refresh(cacheName);
                CacheData = null;
            }

            return result;
        }


        /// <summary>
        /// 刷新缓存
        /// </summary>
        /// <param name="cacheType"></param>
        /// <returns></returns>
        public Result.Result Refresh(string cacheName)
        {
            var sysKey = SysKeyConfig._sysKeys.Where(w => w.Id == cacheName).FirstOrDefault();
            if (null == sysKey)
            {
                return new Result.Result(string.Format("未配置{0}缓存系统密钥", cacheName));
            }

            if (string.IsNullOrWhiteSpace(sysKey.Url))
            {
                return new Result.Result(string.Format("未配置{0}缓存系统网络地址", cacheName));
            }

            var url = sysKey.Url.ToLower();
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                return new Result.Result("请配置网络正确的地址");
            }

            try
            {
                var httpRequest = new HttpRequest(HttpMethod.Post, string.Format("{0}/api/cache/{1}refresh", url, cacheName));
                httpRequest.ContentType(HttpContentType.FormUrlEncoded);
                var parameters = new Dictionary<string, object>();
                parameters.Add("cacheType", cacheName);
                parameters.Add("key", sysKey.Key);
                httpRequest.Data(parameters);

                var requeryData = httpRequest.ResultFromJsonAsync<Result.Result>().Result;
                return requeryData;
            }
            catch (Exception ex)
            {
                return new Result.Result(ex.Message);
            }

        }
    }
}
