using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Auth.Param
{
    public class Client
    {
        /// <summary>
        /// 客户端编号
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// secret
        /// </summary>
        public string Client_Secret { get; set; } = "secret";

        /// <summary>
        /// 授权类型
        /// </summary>
        public string Grant_Type { get; set; } = "password";

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
