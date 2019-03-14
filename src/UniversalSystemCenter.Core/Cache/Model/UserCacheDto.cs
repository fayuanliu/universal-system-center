using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    /// <summary>
    /// 用户缓存
    /// </summary>
    public class UserCacheDto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 微信编号
        /// </summary>
        public string WeChat { get; set; }

        /// <summary>
        /// 公众号编号
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// QQ号
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 微博号
        /// </summary>
        public string Weibo { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
    }
}
