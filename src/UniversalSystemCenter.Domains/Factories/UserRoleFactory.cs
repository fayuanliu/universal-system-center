using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 用户角色工厂
    /// </summary>
    public static class UserRoleFactory {
        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="userRoleId">用户角色编号（UserRoleId）</param>
        /// <param name="roleId">类型编号（TypeId）</param>
        /// <param name="userId">用户编号（UserId)</param>
        /// <param name="version">Version</param>
        public static UserRole Create( 
            Guid userRoleId,
            Guid roleId,
            Guid userId,
            Byte[] version
        ) {
            UserRole result;
            result = new UserRole( userRoleId );
            result.RoleId = roleId;
            result.UserId = userId;
            result.Version = version;
            return result;
        }
    }
}