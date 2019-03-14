using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 角色菜单数据传输对象扩展
    /// </summary>
    public static class RoleMenuDtoExtension {
        /// <summary>
        /// 转换为角色菜单实体
        /// </summary>
        /// <param name="dto">角色菜单数据传输对象</param>
        public static RoleMenu ToEntity( this RoleMenuDto dto ) {
            if ( dto == null )
                return new RoleMenu();
            return dto.MapTo( new RoleMenu( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为角色菜单实体
        /// </summary>
        /// <param name="dto">角色菜单数据传输对象</param>
        public static RoleMenu ToEntity2( this RoleMenuDto dto ) {
            if( dto == null )
                return new RoleMenu();
            return new RoleMenu( dto.Id.ToGuid() ) {
                MenuId = dto.MenuId,
                RoleId = dto.RoleId,
                Half = dto.Half,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为角色菜单实体
        /// </summary>
        /// <param name="dto">角色菜单数据传输对象</param>
        public static RoleMenu ToEntity3( this RoleMenuDto dto ) {
            if( dto == null )
                return new RoleMenu();
            return RoleMenuFactory.Create(
                roleMenuId : dto.Id.ToGuid(),
                menuId : dto.MenuId,
                roleId : dto.RoleId,
                half : dto.Half,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为角色菜单数据传输对象
        /// </summary>
        /// <param name="entity">角色菜单实体</param>
        public static RoleMenuDto ToDto(this RoleMenu entity) {
            if( entity == null )
                return new RoleMenuDto();
            return entity.MapTo<RoleMenuDto>();
        }

        /// <summary>
        /// 转换为角色菜单数据传输对象
        /// </summary>
        /// <param name="entity">角色菜单实体</param>
        public static RoleMenuDto ToDto2( this RoleMenu entity ) {
            if( entity == null )
                return new RoleMenuDto();
            return new RoleMenuDto {
                Id = entity.Id.ToString(),
                MenuId = entity.MenuId,
                RoleId = entity.RoleId,
                Half = entity.Half,
                Version = entity.Version,
            };
        }
    }
}