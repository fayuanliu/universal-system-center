using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.SysKey
{
    /// <summary>
    /// 系统密钥
    /// </summary>
    public class SysKey
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 请求地址(不带控制器)
        /// </summary>
        public string Url { get; set; }
    }
}
