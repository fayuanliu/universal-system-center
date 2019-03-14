using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UniversalSystemCenter.Core.Cache.CSRedis
{
    /// <summary>
    /// 缓存表名前缀枚举
    /// </summary>
    public enum CacheTableEnum
    {
        /// <summary>
        /// 用户
        /// </summary>
        [Description("User_")]
        UserTable,

        /// <summary>
        /// 组织
        /// </summary>
        [Description("Organization_")]
        OrganizationTable,
    }
}
