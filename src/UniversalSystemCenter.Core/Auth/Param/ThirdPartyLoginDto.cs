using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UniversalSystemCenter.Core.Auth.Param
{
    /// <summary>
    /// 
    /// </summary>
    public class ThirdPartyLoginDto
    {
        /// <summary>
        /// 昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// 第三登录凭证ID(注：WeChatOpenId)
        /// </summary>
        public string uid { get; set; }

        /// <summary>
        /// 类型（qq,weix,weibo）
        /// </summary>
        public UserThirdPartyAppType PlatformType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 凭证
        /// </summary>
        public string Credential { get; set; }

        /// <summary>
        /// 登录客户端
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public int Source { get; set; }
    }




    /// <summary>
    /// 社交账号枚举
    /// </summary>
    public enum UserThirdPartyAppType
    {
        /// <summary>
        /// 微博
        /// </summary>
        [Description("微博")]
        Weibo = 1,
        /// <summary>
        /// qq
        /// </summary>
        [Description("微博")]
        QQ = 998,
        /// <summary>
        /// 微信第三方Unionid
        /// </summary>
        [Description("微信第三方")]
        WeChatUnionId = 997,
        /// <summary>
        /// 微信小程序MPOpenId
        /// </summary>
        [Description("微信小程序")]
        WeChatMPOpenId = 996,
        /// <summary>
        /// 微信公众号
        /// </summary>
        [Description("微信公众号")]
        WeChatOpenId = 33
    }
}
