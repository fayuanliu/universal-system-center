using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 权限数据传输对象扩展
    /// </summary>
    public static class PermissionDtoExtension {
        /// <summary>
        /// 转换为权限实体
        /// </summary>
        /// <param name="dto">权限数据传输对象</param>
        public static Permission ToEntity( this PermissionDto dto ) {
            if ( dto == null )
                return new Permission();
            return dto.MapTo( new Permission( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为权限实体
        /// </summary>
        /// <param name="dto">权限数据传输对象</param>
        public static Permission ToEntity2( this PermissionDto dto ) {
            if( dto == null )
                return new Permission();
            return new Permission( dto.Id.ToGuid() ) {
                Name = dto.Name,
                Code = dto.Code,
                ResourceId = dto.ResourceId,
                IsEnabled = dto.IsEnabled,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为权限实体
        /// </summary>
        /// <param name="dto">权限数据传输对象</param>
        public static Permission ToEntity3( this PermissionDto dto ) {
            if( dto == null )
                return new Permission();
            return PermissionFactory.Create(
                permissionId : dto.Id.ToGuid(),
                name : dto.Name,
                code : dto.Code,
                resourceId : dto.ResourceId,
                isEnabled : dto.IsEnabled,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为权限数据传输对象
        /// </summary>
        /// <param name="entity">权限实体</param>
        public static PermissionDto ToDto(this Permission entity) {
            if( entity == null )
                return new PermissionDto();
            return entity.MapTo<PermissionDto>();
        }

        /// <summary>
        /// 转换为权限数据传输对象
        /// </summary>
        /// <param name="entity">权限实体</param>
        public static PermissionDto ToDto2( this Permission entity ) {
            if( entity == null )
                return new PermissionDto();
            return new PermissionDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                Code = entity.Code,
                ResourceId = entity.ResourceId,
                IsEnabled = entity.IsEnabled,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}