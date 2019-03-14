using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Auth.Param
{
    public class LoginDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 记住
        /// </summary>

        public bool RememberMe { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string VerificationCode { get; set; }

        /// <summary>
        /// 跳转URL
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 客户端编号
        /// </summary>
        public string ClientId { get; set; }
    }
}
