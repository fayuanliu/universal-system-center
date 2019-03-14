using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Auth.Param
{
    public class AuthResut
    {
        /// <summary>
        /// 错误
        /// </summary>
        public string error { get; set; }

        /// <summary>
        /// token
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public int expires_in { get; set; }

        /// <summary>
        /// token类型
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        public string error_description { get; set; }
        /// <summary>
        /// 登录用户信息
        /// </summary>
        public LoginUser user { get; set; }
    }

    public class LoginUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 组织机构编号
        /// </summary>       
        public string OrganizationsId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>       
        public string UserName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// 头像
        /// </summary>       
        public string Head { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>        
        public string Mobile { get; set; }

        /// <summary>
        /// 注册日期（RegisterTime）
        /// </summary>        
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 锁定
        /// </summary>        
        public bool IsLocked { get; set; }

        /// <summary>
        /// 锁定起始时间
        /// </summary>       
        public DateTime? LockBeginTime { get; set; }

        /// <summary>
        /// 锁定持续时间
        /// </summary>       
        public int? LockDuration { get; set; }

        /// <summary>
        /// 锁定提示消息
        /// </summary>        
        public string LockMessage { get; set; }

        /// <summary>
        /// 上次登陆时间
        /// </summary>       
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// 上次登陆Ip
        /// </summary>       
        public string LastLoginIp { get; set; }
        /// <summary>
        /// 本次登陆时间
        /// </summary>

        public DateTime? CurrentLoginTime { get; set; }

        /// <summary>
        /// 本次登陆Ip
        /// </summary>       
        public string CurrentLoginIp { get; set; }

        /// <summary>
        /// 状态
        /// </summary>        
        public int State { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public List<string> RoleIdList { get; set; }
       
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 盐值
        /// </summary>
        public string Saltd { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        public int StoresType { get; set; }

        /// <summary>
        /// 团队编号
        /// </summary>
        public string StoresId { get; set; }

        /// <summary>
        /// 团队姓名
        /// </summary>
        public string StoresName { get; set; }
    }
}
