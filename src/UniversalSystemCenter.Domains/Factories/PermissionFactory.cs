using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 权限工厂
    /// </summary>
    public static class PermissionFactory {
        /// <summary>
        /// 创建权限
        /// </summary>
        /// <param name="permissionId">权限编号（PermissionId）</param>
        /// <param name="name">权限名称（Name)</param>
        /// <param name="code">权限点（Code）</param>
        /// <param name="resourceId">资源编号（ResourceId）</param>
        /// <param name="isEnabled">启用</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Permission Create( 
            Guid permissionId,
            string name,
            string code,
            Guid? resourceId,
            byte isEnabled,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Permission result;
            result = new Permission( permissionId );
            result.Name = name;
            result.Code = code;
            result.ResourceId = resourceId;
            result.IsEnabled = isEnabled;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}