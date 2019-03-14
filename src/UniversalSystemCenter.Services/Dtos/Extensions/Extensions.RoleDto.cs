using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 角色数据传输对象扩展
    /// </summary>
    public static class RoleDtoExtension {
        /// <summary>
        /// 转换为角色实体
        /// </summary>
        /// <param name="dto">角色数据传输对象</param>
        public static Role ToEntity( this RoleDto dto ) {
            if ( dto == null )
                return new Role();
            return dto.MapTo( new Role( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为角色实体
        /// </summary>
        /// <param name="dto">角色数据传输对象</param>
        public static Role ToEntity2( this RoleDto dto ) {
            if( dto == null )
                return new Role();
            return new Role( dto.Id.ToGuid() ) {
                Name = dto.Name,
                Values = dto.Values,
                Icon = dto.Icon,
                IsEnabled = dto.IsEnabled,
                SortId = dto.SortId,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                MerchantId = dto.MerchantId,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为角色实体
        /// </summary>
        /// <param name="dto">角色数据传输对象</param>
        public static Role ToEntity3( this RoleDto dto ) {
            if( dto == null )
                return new Role();
            return RoleFactory.Create(
                roleId : dto.Id.ToGuid(),
                name : dto.Name,
                values : dto.Values,
                icon : dto.Icon,
                isEnabled : dto.IsEnabled,
                sortId : dto.SortId,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                merchantId : dto.MerchantId,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为角色数据传输对象
        /// </summary>
        /// <param name="entity">角色实体</param>
        public static RoleDto ToDto(this Role entity) {
            if( entity == null )
                return new RoleDto();
            return entity.MapTo<RoleDto>();
        }

        /// <summary>
        /// 转换为角色数据传输对象
        /// </summary>
        /// <param name="entity">角色实体</param>
        public static RoleDto ToDto2( this Role entity ) {
            if( entity == null )
                return new RoleDto();
            return new RoleDto {
                Id = entity.Id.ToString(),
                Name = entity.Name,
                Values = entity.Values,
                Icon = entity.Icon,
                IsEnabled = entity.IsEnabled,
                SortId = entity.SortId,
                CreationTime = entity.CreationTime,
                CreatorId = entity.CreatorId,
                LastModificationTime = entity.LastModificationTime,
                LastModifierId = entity.LastModifierId,
                IsDeleted = entity.IsDeleted,
                MerchantId = entity.MerchantId,
                Version = entity.Version,
            };
        }
    }
}