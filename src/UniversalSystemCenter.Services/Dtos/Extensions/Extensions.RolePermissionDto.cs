using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 角色权限数据传输对象扩展
    /// </summary>
    public static class RolePermissionDtoExtension {
        /// <summary>
        /// 转换为角色权限实体
        /// </summary>
        /// <param name="dto">角色权限数据传输对象</param>
        public static RolePermission ToEntity( this RolePermissionDto dto ) {
            if ( dto == null )
                return new RolePermission();
            return dto.MapTo( new RolePermission( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为角色权限实体
        /// </summary>
        /// <param name="dto">角色权限数据传输对象</param>
        public static RolePermission ToEntity2( this RolePermissionDto dto ) {
            if( dto == null )
                return new RolePermission();
            return new RolePermission( dto.Id.ToGuid() ) {
                RoleId = dto.RoleId,
                PermissionId = dto.PermissionId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为角色权限实体
        /// </summary>
        /// <param name="dto">角色权限数据传输对象</param>
        public static RolePermission ToEntity3( this RolePermissionDto dto ) {
            if( dto == null )
                return new RolePermission();
            return RolePermissionFactory.Create(
                rolePermissionId : dto.Id.ToGuid(),
                roleId : dto.RoleId,
                permissionId : dto.PermissionId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为角色权限数据传输对象
        /// </summary>
        /// <param name="entity">角色权限实体</param>
        public static RolePermissionDto ToDto(this RolePermission entity) {
            if( entity == null )
                return new RolePermissionDto();
            return entity.MapTo<RolePermissionDto>();
        }

        /// <summary>
        /// 转换为角色权限数据传输对象
        /// </summary>
        /// <param name="entity">角色权限实体</param>
        public static RolePermissionDto ToDto2( this RolePermission entity ) {
            if( entity == null )
                return new RolePermissionDto();
            return new RolePermissionDto {
                Id = entity.Id.ToString(),
                RoleId = entity.RoleId,
                PermissionId = entity.PermissionId,
                Version = entity.Version,
            };
        }
    }
}