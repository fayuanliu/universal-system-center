using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Configuration
{
    public class AuthHostConfiguration
    {
        /// <summary>
        /// 切图软件地址
        /// </summary>
        public string PaonExePath { get; set; }

        /// <summary>
        /// 微信回调地址
        /// </summary>
        public string WeChatNotifyUrl { get; set; }


        /// <summary>
        /// 图片服务器地址
        /// </summary>
        public string LocalImageHost { get; set; }

        /// <summary>
        /// 授权地址
        /// </summary>
        public string Authority { get; set; }

    }
}
