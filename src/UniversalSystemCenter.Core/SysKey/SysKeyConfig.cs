using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.SysKey
{
    /// <summary>
    /// 系统密钥配置
    /// </summary>
    public static class SysKeyConfig
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        public static List<SysKey> _sysKeys = new List<SysKey>();

        /// <summary>
        /// 注册系统密钥
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddSysKey(this IServiceCollection service, IConfiguration  configuration)
        {
            try
            {
                _sysKeys = configuration.GetSection("SysKeyConfig").Get<List<SysKey>>();
            }
            catch { }

            return service;
        }
    }
}
