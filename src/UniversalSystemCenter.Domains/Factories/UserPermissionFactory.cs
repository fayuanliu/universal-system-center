using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 用户权限工厂
    /// </summary>
    public static class UserPermissionFactory {
        /// <summary>
        /// 创建用户权限
        /// </summary>
        /// <param name="userPermissionId">用户权限编号</param>
        /// <param name="permissionId">权限编号（PermissionId）</param>
        /// <param name="userId">用户编号（UserId)</param>
        public static UserPermission Create( 
            Guid userPermissionId,
            Guid permissionId,
            Guid userId
        ) {
            UserPermission result;
            result = new UserPermission( userPermissionId );
            result.PermissionId = permissionId;
            result.UserId = userId;
            return result;
        }
    }
}