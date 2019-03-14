using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 用户权限数据传输对象扩展
    /// </summary>
    public static class UserPermissionDtoExtension {
        /// <summary>
        /// 转换为用户权限实体
        /// </summary>
        /// <param name="dto">用户权限数据传输对象</param>
        public static UserPermission ToEntity( this UserPermissionDto dto ) {
            if ( dto == null )
                return new UserPermission();
            return dto.MapTo( new UserPermission( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为用户权限实体
        /// </summary>
        /// <param name="dto">用户权限数据传输对象</param>
        public static UserPermission ToEntity2( this UserPermissionDto dto ) {
            if( dto == null )
                return new UserPermission();
            return new UserPermission( dto.Id.ToGuid() ) {
                PermissionId = dto.PermissionId,
                UserId = dto.UserId,
            };
        }
        
        /// <summary>
        /// 转换为用户权限实体
        /// </summary>
        /// <param name="dto">用户权限数据传输对象</param>
        public static UserPermission ToEntity3( this UserPermissionDto dto ) {
            if( dto == null )
                return new UserPermission();
            return UserPermissionFactory.Create(
                userPermissionId : dto.Id.ToGuid(),
                permissionId : dto.PermissionId,
                userId : dto.UserId
            );
        }
        
        /// <summary>
        /// 转换为用户权限数据传输对象
        /// </summary>
        /// <param name="entity">用户权限实体</param>
        public static UserPermissionDto ToDto(this UserPermission entity) {
            if( entity == null )
                return new UserPermissionDto();
            return entity.MapTo<UserPermissionDto>();
        }

        /// <summary>
        /// 转换为用户权限数据传输对象
        /// </summary>
        /// <param name="entity">用户权限实体</param>
        public static UserPermissionDto ToDto2( this UserPermission entity ) {
            if( entity == null )
                return new UserPermissionDto();
            return new UserPermissionDto {
                Id = entity.Id.ToString(),
                PermissionId = entity.PermissionId,
                UserId = entity.UserId,
            };
        }
    }
}