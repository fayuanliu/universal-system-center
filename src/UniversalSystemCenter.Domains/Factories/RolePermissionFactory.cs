using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 角色权限工厂
    /// </summary>
    public static class RolePermissionFactory {
        /// <summary>
        /// 创建角色权限
        /// </summary>
        /// <param name="rolePermissionId">角色权限编号（RolePermissionId）</param>
        /// <param name="roleId">类型编号（TypeId）</param>
        /// <param name="permissionId">权限编号（PermissionId）</param>
        /// <param name="version">Version</param>
        public static RolePermission Create( 
            Guid rolePermissionId,
            Guid roleId,
            Guid permissionId,
            Byte[] version
        ) {
            RolePermission result;
            result = new RolePermission( rolePermissionId );
            result.RoleId = roleId;
            result.PermissionId = permissionId;
            result.Version = version;
            return result;
        }
    }
}