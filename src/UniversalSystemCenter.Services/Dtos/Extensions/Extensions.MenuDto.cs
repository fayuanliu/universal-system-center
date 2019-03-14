using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 菜单数据传输对象扩展
    /// </summary>
    public static class MenuDtoExtension {
        /// <summary>
        /// 转换为菜单实体
        /// </summary>
        /// <param name="dto">菜单数据传输对象</param>
        public static Menu ToEntity( this MenuDto dto ) {
            if ( dto == null )
                return new Menu();
            return dto.MapTo( new Menu( dto.Id.ToGuid(),"",1 ) );
        }
        
        /// <summary>
        /// 转换为菜单实体
        /// </summary>
        /// <param name="dto">菜单数据传输对象</param>
        public static Menu ToEntity2( this MenuDto dto ) {
            if( dto == null )
                return new Menu();
            return new Menu( dto.Id.ToGuid(), "", 1) {
                AppId = dto.AppId,
                Name = dto.Name,
                IsGroup = dto.IsGroup,
                Link = dto.Link,
                PathText = dto.PathText,
                Icon = dto.Icon,
                IsLeave = dto.IsLeave,
                Badge = dto.Badge,
                IsOpen = dto.IsOpen,
                Code = dto.Code,
                ParentId = dto.ParentId.ToGuidOrNull(),
                Enabled = dto.Enabled.Value,
                SortId = dto.SortId,
                PinYin = dto.PinYin,
                CreationTime = dto.CreationTime,
                CreatorId = dto.CreatorId,
                LastModificationTime = dto.LastModificationTime,
                LastModifierId = dto.LastModifierId,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为菜单实体
        /// </summary>
        /// <param name="dto">菜单数据传输对象</param>
        public static Menu ToEntity3( this MenuDto dto ) {
            if( dto == null )
                return new Menu();
            return MenuFactory.Create(
                menuId : dto.Id.ToGuid(),
                appId : dto.AppId,
                name : dto.Name,
                isGroup : dto.IsGroup,
                link : dto.Link,
                pathText : dto.PathText,
                icon : dto.Icon,
                isLeave : dto.IsLeave,
                badge : dto.Badge,
                isOpen : dto.IsOpen,
                code : dto.Code,
                parentId : dto.ParentId.ToGuidOrNull(),
                path : dto.Path,
                level : dto.Level.Value,
                enabled : dto.Enabled.Value,
                sortId : dto.SortId.Value,
                pinYin : dto.PinYin,
                creationTime : dto.CreationTime,
                creatorId : dto.CreatorId,
                lastModificationTime : dto.LastModificationTime,
                lastModifierId : dto.LastModifierId,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为菜单数据传输对象
        /// </summary>
        /// <param name="entity">菜单实体</param>
        public static MenuDto ToDto(this Menu entity) {
            if( entity == null )
                return new MenuDto();
            return entity.MapTo<MenuDto>();
        }

        /// <summary>
        /// 转换为菜单数据传输对象
        /// </summary>
        /// <param name="entity">菜单实体</param>
        public static MenuDto ToDto2( this Menu entity ) {
            if( entity == null )
                return new MenuDto();
            return new MenuDto {
                Id = entity.Id.ToString(),
                AppId = entity.AppId,
                Name = entity.Name,
                IsGroup = entity.IsGroup,
                Link = entity.Link,
                PathText = entity.PathText,
                Icon = entity.Icon,
                IsLeave = entity.IsLeave,
                Badge = entity.Badge,
                IsOpen = entity.IsOpen,
                Code = entity.Code,
                ParentId = entity.ParentId.ToString(),
                Path = entity.Path,
                Level = entity.Level,
                Enabled = entity.Enabled,
                SortId = entity.SortId,
                PinYin = entity.PinYin,
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