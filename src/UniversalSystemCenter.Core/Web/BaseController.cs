using Microsoft.AspNetCore.Mvc;
using System;
using Util;
using System.Linq;
using System.Collections.Generic;
using IdentityModel;
using UniversalSystemCenter.Core.Auth.Param;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using UniversalSystemCenter.Core.Utils;

namespace UniversalSystemCenter.Core.Web
{
    /// <summary>
    /// 基控制器
    /// </summary>
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public Guid UserId
        {
            get
            {
                var userId = User.Claims.FirstOrDefault(a => a.Type == JwtClaimTypes.Id);
                if (null != userId)
                {
                    return userId.Value.ToGuid();
                }
                return Guid.Empty;
            }
        }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string Head
        {
            get
            {
                var head = User.Claims.FirstOrDefault(a => a.Type == "Head");
                if (null != head)
                {
                    return head.Value;
                }
                return string.Empty;
            }
        }


        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string RealName
        {
            get
            {
                var realName = User.Claims.FirstOrDefault(a => a.Type == "RealName");
                if (null != realName)
                {
                    return realName.Value;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// 用户角色编号
        /// </summary>
        public List<Guid> RoleIdList
        {
            get
            {
                var userRoleIdStr = User.Claims.FirstOrDefault(a => a.Type == "RoleIds");
                if (null != userRoleIdStr)
                {
                    return userRoleIdStr.Value.ToGuidList();
                }
                return new List<Guid>();
            }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                var userRoleIdStr = User.Claims.FirstOrDefault(a => a.Type == JwtClaimTypes.Name);
                if (null != userRoleIdStr)
                {
                    return userRoleIdStr.Value;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string OrganizationsId
        {
            get
            {
                var organizationsId = User.Claims.FirstOrDefault(x => x.Type == "OrganizationsId");
                if (null != organizationsId)
                {
                    return organizationsId.ToString();
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// 登录用户信息
        /// </summary>
        public LoginUser LoginUser
        {
            get
            {
                var memoryCache = Util.Helpers.Ioc.Create<IMemoryCache>();
                LoginUser loginUser = memoryCache.Get<LoginUser>(UserId.ToString());
                if (null == loginUser)
                {
                    loginUser = RedisHelper.Get<LoginUser>(UserId.ToString());
                    memoryCache.Set<LoginUser>(loginUser.Id, loginUser, TimeSpan.FromHours(3));
                }
                return loginUser;
            }
        }

        [NonAction]
        public JsonResult ToJson(object data)
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new NullToEmptyStringResolver()
            };
            return base.Json(data, settings);
        }
    }
}
