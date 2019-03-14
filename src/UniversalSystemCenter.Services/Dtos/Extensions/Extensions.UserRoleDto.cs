using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 用户角色数据传输对象扩展
    /// </summary>
    public static class UserRoleDtoExtension {
        /// <summary>
        /// 转换为用户角色实体
        /// </summary>
        /// <param name="dto">用户角色数据传输对象</param>
        public static UserRole ToEntity( this UserRoleDto dto ) {
            if ( dto == null )
                return new UserRole();
            return dto.MapTo( new UserRole( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为用户角色实体
        /// </summary>
        /// <param name="dto">用户角色数据传输对象</param>
        public static UserRole ToEntity2( this UserRoleDto dto ) {
            if( dto == null )
                return new UserRole();
            return new UserRole( dto.Id.ToGuid() ) {
                RoleId = dto.RoleId,
                UserId = dto.UserId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为用户角色实体
        /// </summary>
        /// <param name="dto">用户角色数据传输对象</param>
        public static UserRole ToEntity3( this UserRoleDto dto ) {
            if( dto == null )
                return new UserRole();
            return UserRoleFactory.Create(
                userRoleId : dto.Id.ToGuid(),
                roleId : dto.RoleId,
                userId : dto.UserId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为用户角色数据传输对象
        /// </summary>
        /// <param name="entity">用户角色实体</param>
        public static UserRoleDto ToDto(this UserRole entity) {
            if( entity == null )
                return new UserRoleDto();
            return entity.MapTo<UserRoleDto>();
        }

        /// <summary>
        /// 转换为用户角色数据传输对象
        /// </summary>
        /// <param name="entity">用户角色实体</param>
        public static UserRoleDto ToDto2( this UserRole entity ) {
            if( entity == null )
                return new UserRoleDto();
            return new UserRoleDto {
                Id = entity.Id.ToString(),
                RoleId = entity.RoleId,
                UserId = entity.UserId,
                Version = entity.Version,
            };
        }
    }
}